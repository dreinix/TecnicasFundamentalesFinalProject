using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            BindingSource MasterSource = new BindingSource();
            MasterSource.DataSource = DBControl.ObtenerTabla("Select * from Maestros");
            DGVMaetro.DataSource = MasterSource;
            DGVMaetro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMaetro.ReadOnly = true;
        }

        private void DGVMaetro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTDetallar_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = ms = new MemoryStream((byte[])DGVMaetro.CurrentRow.Cells[2].Value);

                Ver.VerDetallesMaestro detalle = new Ver.VerDetallesMaestro(DGVMaetro.CurrentRow.Cells[0].Value.ToString(), 
                    DGVMaetro.CurrentRow.Cells[1].Value.ToString(), Image.FromStream(ms));
                detalle.ShowDialog();
            }
            catch (Exception)
            {
                Image img = Image.FromFile("intec.png");
                Ver.VerDetallesMaestro detalle = new Ver.VerDetallesMaestro(DGVMaetro.CurrentRow.Cells[0].Value.ToString(),
                    DGVMaetro.CurrentRow.Cells[1].Value.ToString(), img);
                detalle.ShowDialog();
            }
        }
    }
}
