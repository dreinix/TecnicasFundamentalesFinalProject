using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal
{
    public partial class BuscarAlumnosForm : Material
    {
        public BuscarAlumnosForm()
        {
            InitializeComponent();
            this.Size = new Size(1589, 750);
        }

        private void BuscarAlumnosForm_Load(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            BindingSource AlmSource = new BindingSource();
            AlmSource.DataSource = DBControl.ObtenerTabla("Select * from Alumnos");
            DGVAlumnos.DataSource = AlmSource;
            DGVAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAlumnos.ReadOnly = true;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            BindingSource AlmSource = new BindingSource();
            string[] parameters = { "@word" };
            string[] value = {TxtBuscar.Text};
            AlmSource.DataSource = DBControl.ObtenerTabla("Select * from Alumnos where [Nombre] like '%'+@word+'%' or [ID] like '%'+@word+'%' ",parameters,value);
            DGVAlumnos.DataSource = AlmSource;
            DGVAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAlumnos.ReadOnly = true;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
