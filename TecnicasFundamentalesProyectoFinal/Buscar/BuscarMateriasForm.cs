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
    public partial class BuscarMateriasForm : Material
    {
        public BuscarMateriasForm()
        {
            InitializeComponent();
        }

        private void BuscarMateriasForm_Load(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            BindingSource MatSource = new BindingSource();
            MatSource.DataSource = DBControl.ObtenerTabla("Select * from Materias");
            DGVMaterias.DataSource = MatSource;
            DGVMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMaterias.ReadOnly = true;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            BindingSource MatSource = new BindingSource();
            string[] parameters = { "@word" };
            string[] value = {TxtBuscar.Text};
            MatSource.DataSource = DBControl.ObtenerTabla("Select * from Materias where [Nombre] like '%'+@word+'%' or [Clave] like '%'+@word+'%' ", parameters, value);
            DGVMaterias.DataSource = MatSource;
            DGVMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMaterias.ReadOnly = true;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {   
            
            this.Close();
        }
    }
}
