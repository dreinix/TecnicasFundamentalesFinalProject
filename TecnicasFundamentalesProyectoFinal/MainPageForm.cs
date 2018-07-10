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
    public partial class MainPageForm : MaterialForm
    {
        string userCat;
        public MainPageForm(string _userCat)
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
            userCat = _userCat;

            if (userCat == "Adm" || userCat == "Develop")
            {
                MenuSAdmin.Visible = true;
                MenuSUsers.Visible = false;

            }
            else
            {
                MenuSAdmin.Visible = false;
                MenuSUsers.Visible = true;
            }
            this.Sizable = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
            this.IsMdiContainer = true;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            AgregarUsuarioForm prueba = new AgregarUsuarioForm("User");
            prueba.MdiParent = this;
            prueba.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            prueba.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAlumnoForm registrarAlumno = new AgregarAlumnoForm();
            registrarAlumno.MdiParent = this;
            
            registrarAlumno.Show();

        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AgregarUsuarioForm registrar = new AgregarUsuarioForm(userCat);
            registrar.MdiParent = this;
            registrar.MinimizeBox = false;
            registrar.MaximizeBox = false;
            registrar.ControlBox = false;
            
            registrar.Show();
        }

        private void MenuSAdmin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void ssToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerraraSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EliminarUsuarioForm eliminar = new EliminarUsuarioForm();
            eliminar.MdiParent = this;
            eliminar.WindowState = FormWindowState.Maximized;
            eliminar.Show();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == this.GetType() && frm != this)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
            this.Dispose();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
             
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerAlumnosForm ver = new VerAlumnosForm();
            ver.MdiParent = this;
            ver.WindowState = FormWindowState.Maximized;
            ver.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VerMateriasForm materias = new VerMateriasForm();
            materias.MdiParent = this;
            materias.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAlumnosForm ver = new BuscarAlumnosForm();
            ver.MdiParent = this;
            ver.WindowState = FormWindowState.Maximized;
            ver.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BuscarMateriasForm ver = new BuscarMateriasForm();
            ver.MdiParent = this;
            ver.WindowState = FormWindowState.Maximized;
            ver.Show();
        }

        private void buscarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BuscarMaestrosForm ver = new BuscarMaestrosForm();
            ver.MdiParent = this;
            ver.WindowState = FormWindowState.Maximized;
            ver.Show();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VerMaestrosForm ver = new VerMaestrosForm();
            ver.MdiParent = this;
            ver.WindowState = FormWindowState.Maximized;
            ver.Show();
        }
    }
}
