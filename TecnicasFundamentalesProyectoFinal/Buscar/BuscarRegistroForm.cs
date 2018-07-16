using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal.Buscar
{
    public partial class BuscarRegistroForm : Material
    {
        public BuscarRegistroForm()
        {
            InitializeComponent();
        }

        private void BuscarRegistroForm_Load(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            BindingSource AlmSource = new BindingSource();
            string[] parameters = { "@word" };
            string[] value = { TxtBuscar.Text };
            AlmSource.DataSource = DBControl.ObtenerTabla("Select [Materia],[Calificacion],[CalificacionLiteral] from Registro where [Alumno] = 0 ", parameters, value);
            DGVAlumnos.DataSource = AlmSource;
            DGVAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAlumnos.ReadOnly = true;
        }

        private void LbBuscar_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Dictionary<char, int> valores = new Dictionary<char, int>
            {
                { 'A', 4 },
                { 'B', 3 },
                { 'C', 2 },
                { 'D', 1 },
                { 'F', 0 }
            };
            LBIndice.Text = "0";
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            BindingSource AlmSource = new BindingSource();
            string[] parameters = { "@word" };
            string[] value = { TxtBuscar.Text };
            AlmSource.DataSource = DBControl.ObtenerTabla("Select [Materia],[Calificacion],[CalificacionLiteral] from [Registro] where [Alumno] =@word", parameters, value);
            DGVAlumnos.DataSource = AlmSource;
            DGVAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAlumnos.ReadOnly = true;
            try
            {
                int suma = 0, total = 0;
                for (int i = 0; i < DGVAlumnos.Rows.Count; i++)
                {
                    string[] para = { "@id" };
                    string[] val = { DGVAlumnos.CurrentRow.Cells[0].Value.ToString() };
                    int credito = int.Parse(DBControl.BuscarElemento("Select [Credito] from [Materias] where [Clave]=@id", para, val));
                    total += credito;
                    string literal = (DGVAlumnos.CurrentRow.Cells[2].Value.ToString().ToUpper());
                    string test = "" + literal;
                    suma += valores[literal[0]] * credito;
                }
                LBIndice.Text = (suma / total).ToString();
            }
            catch (Exception ex) { /*MessageBox.Show(ex.Message);*/ }
            
        }
    }
}
