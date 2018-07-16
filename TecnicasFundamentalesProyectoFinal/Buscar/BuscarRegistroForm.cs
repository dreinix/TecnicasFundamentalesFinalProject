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
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            BindingSource AlmSource = new BindingSource();
            string[] parameters = { "@word" };
            string[] value = { TxtBuscar.Text };
            AlmSource.DataSource = DBControl.ObtenerTabla("Select [Materia],[Calificacion],[CalificacionLiteral] from Registro where [Alumno] like '%'+@word+'%' ", parameters, value);
            DGVAlumnos.DataSource = AlmSource;
            DGVAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAlumnos.ReadOnly = true;

            int indice = 0;

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
