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
    public partial class BuscarMateriasForm : MaterialForm
    {
        public BuscarMateriasForm()
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

        private void BuscarMateriasForm_Load(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            BindingSource MatSource = new BindingSource();
            MatSource.DataSource = DBControl.ObtenerTabla("Select * from Materias");
            DGVMaterias.DataSource = MatSource;
            DGVMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMaterias.ReadOnly = true;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            BindingSource MatSource = new BindingSource();
            string[] parameters = { "@word" };
            string[] value = {TxtBuscar.Text};
            MatSource.DataSource = DBControl.ObtenerTabla("Select * from Materias where [Nombre] like '%'+@word+'%' or [Codigo] like '%'+@word+'%' ", parameters, value);
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
