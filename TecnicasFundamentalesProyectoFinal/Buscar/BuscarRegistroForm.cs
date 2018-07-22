using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
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
            LBHonor.Text = "Ninguno";
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            BindingSource AlmSource = new BindingSource();
            string[] parameters = { "@word" };
            string[] value = { TxtBuscar.Text };
            AlmSource.DataSource = DBControl.ObtenerTabla("Select [Materia],[Calificacion],[CalificacionLiteral] from [Registro] where [Alumno] =@word", parameters, value);
            DGVAlumnos.DataSource = AlmSource;
            DGVAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAlumnos.ReadOnly = true;
            string[] para;
            string[] val;
            try
            {
                float suma = 0, total = 0;
                for (int i = 0; i < DGVAlumnos.Rows.Count; i++)
                {
                    para = new string[] { "@id" };
                    val = new string[] { DGVAlumnos.Rows[i].Cells[0].Value.ToString() };
                    int credito = int.Parse(DBControl.BuscarElemento("Select [Credito] from [Materias] where [Clave]=@id", para, val));
                    total += credito;
                    string literal = (DGVAlumnos.Rows[i].Cells[2].Value.ToString().ToUpper());
                    string test = "" + literal;
                    suma += valores[literal[0]] * credito;
                }
                LBIndice.Text = (suma / total).ToString();
                double indice = double.Parse(LBIndice.Text);
                if (indice > 3.80 && indice < 4.0)
                    LBHonor.Text = "Summa Cum Laude";
                if (indice > 3.50 && indice < 3.79)
                    LBHonor.Text = "Magna Cum Laude";
                if (indice > 3.20 && indice < 3.49)
                    LBHonor.Text = "Cum Laude";
                if (indice < 3.19)
                    LBHonor.Text = "Sin honor";
                SqlConnection con = new SqlConnection();
                using (SqlCommand cmd = new SqlCommand("Update [Alumnos] set [Indice]=@nota where [ID]=@alumno", con))
                {
                    cmd.Parameters.AddWithValue("@alumno", TxtBuscar.Text);
                    cmd.Parameters.AddWithValue("@nota", float.Parse(LBIndice.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { /*MessageBox.Show(ex.Message);*/ } 
        }
    }
}
