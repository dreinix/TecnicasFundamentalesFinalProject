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
    public partial class VerMaestrosForm : Material
    {
        public VerMaestrosForm()
        {
            InitializeComponent();
        }

        private void VerMaestrosForm_Load(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            BindingSource MasterSource = new BindingSource();
            MasterSource.DataSource = DBControl.ObtenerTabla("Select * from Maestros");
            DGVMaetro.DataSource = MasterSource;
            DGVMaetro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMaetro.ReadOnly = true;
        }

        private void DGVAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
