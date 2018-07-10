using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal
{
    public partial class VerAlumnosForm : Material
    {
        public VerAlumnosForm()
        {
            InitializeComponent();
        }


        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerAlumnosForm_Activated(object sender, EventArgs e)
        {

        }
        private void VerAlumnosForm_Load_1(object sender, EventArgs e)
        {

            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            BindingSource AlumnSource = new BindingSource();
            AlumnSource.DataSource = DBControl.ObtenerTabla("Select * from Alumnos");
            DGVAlumno.DataSource = AlumnSource;
            DGVAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAlumno.ReadOnly = true;


        }
    }
}
