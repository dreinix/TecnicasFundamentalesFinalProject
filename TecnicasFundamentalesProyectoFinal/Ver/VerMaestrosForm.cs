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
    public partial class VerMaestrosForm : MaterialForm
    {
        public VerMaestrosForm()
        {
            InitializeComponent();
            MaterialSkinManager MaterialSkinControl = MaterialSkinManager.Instance;
            MaterialSkinControl.AddFormToManage(this);
            MaterialSkinControl.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinControl.ColorScheme = new ColorScheme(
                primary: Primary.Blue400, darkPrimary: Primary.Blue500,
                lightPrimary: Primary.Blue300, accent: Accent.LightBlue200,
                textShade: TextShade.WHITE
                );
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
