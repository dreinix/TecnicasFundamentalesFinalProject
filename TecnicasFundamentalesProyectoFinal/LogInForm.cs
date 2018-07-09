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
    public partial class LogInForm : MaterialForm
    {
        public LogInForm()
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
            this.Sizable = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void InisiarSesion()
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            string[] parameters = { "@id", "@pass" };
            string[] elements = { TxtUserName.Text, TxtPassword.Text };
            TxtUserName.Clear();
            TxtPassword.Clear();
            List<string> admins = new List<string> {"Admin","Develop"};
            if (DBControl.Buscar("select * from Users where [UserName]=@id and [KeyWord]=@pass", parameters, elements))
            {
                string cat = DBControl.BuscarElemento("select [Category] from Users where [UserName]=@id and [KeyWord]=@pass", parameters, elements);
                MainPageForm mainPage = new MainPageForm(cat);
                this.Hide();
                mainPage.ShowDialog();
                this.Show();
                TxtUserName.Focus();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválidos");
                TxtUserName.Focus();
            }
        }
        private void BtInisiarSesion_Click(object sender, EventArgs e)
        {   
            InisiarSesion();

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            TxtUserName.Focus();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                InisiarSesion();
            }
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtPassword.Focus();
            }
        }

        private void BtRegistrarUsuario_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioForm registrarUsuario = new RegistrarUsuarioForm("User");
            this.Hide();
            registrarUsuario.ShowDialog();
            this.Show();
        }
    }
}
