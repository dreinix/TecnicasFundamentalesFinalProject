using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TecnicasFundamentalesProyectoFinal
{
    public partial class RegistrarUsuarioForm : MaterialForm
    {
        string cat;
        public RegistrarUsuarioForm(string _cat)
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
            cat = _cat;
            if(cat=="Adm" || cat=="Develop")
            {
                this.Size = new Size(497, 313);
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.Size = new Size(336, 313);
                LbCat.Hide();
                CBCat.Hide();
                cat = "User";
            }
            this.Sizable = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void MaterialLayout_Load(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            string[] parameters = {"@userName","@pass","cat"};
            string[] elements = { TxtUserName.Text,TxtPass.Text,CBCat.Text };
            if (DBControl.Insertar("insert into Users values(@userName,@pass,@cat)", parameters, elements))
            {
                MessageBox.Show("Usuario agregado");
            }
            else
            {
                MessageBox.Show("El usuario no pudo ser agregado");
            }
            DBControl.Close();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
