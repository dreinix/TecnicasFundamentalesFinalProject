using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal
{
    public partial class Material : MaterialForm
    {
        public Material()
        {
            InitializeComponent();
            InitializeComponent();
            MaterialSkinManager MaterialSkinControl = MaterialSkinManager.Instance;
            MaterialSkinControl.AddFormToManage(this);
            MaterialSkinControl.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinControl.ColorScheme = new ColorScheme(
                primary: Primary.Blue400, darkPrimary: Primary.Blue500,
                lightPrimary: Primary.Blue300, accent: Accent.LightBlue200,
                textShade: TextShade.WHITE
                );
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
        }

        private void MaterialForm_Load(object sender, EventArgs e)
        {

        }
    }
}
