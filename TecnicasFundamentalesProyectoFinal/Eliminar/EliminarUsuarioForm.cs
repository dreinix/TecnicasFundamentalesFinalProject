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
    public partial class EliminarUsuarioForm : Material
    {
        public EliminarUsuarioForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Sizable = false;
            this.ControlBox = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            if (TxtUserName.Text.Length > 0)
            {
                DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
                LVUsuarios.Clear();
                string[] _parameters = {"@userN" };
                string[] _element = { TxtUserName.Text };
                string[] _returned = { "UserName" };
                
                foreach (string[] item in DBControl.Buscar("Select [UserName] from [Users] where [Username] like '%' + @userN + '%'", _parameters, _element, 1))
                {
                    foreach (var it in item)
                    {
                        LVUsuarios.Items.Add(new ListViewItem(it));
                    }
                    
                }
                DBControl.Close();
            }
            
        }

        private void TxtUserName_Click(object sender, EventArgs e)
        {

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            string[] _parameters = { "@UserName", "@userN" };
            foreach (var item in _parameters)
            {   
                    
                LVUsuarios.Items.Add(new ListViewItem(item));
            }
        }

        private void BtEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
                string[] para = { "@user" };
                string[] ele = { TxtUserName.Text };
                if (DBControl.Eliminar("Delete from [Users] where [Username] = @user", para, ele))
                {
                    
                    MessageBox.Show("Usuario eliminado con exito");
                }
                else
                {
                    MessageBox.Show("Error al eliminar usuario");
                }
                DBControl.Close();
            }
            catch (Exception) { MessageBox.Show("Por favor, verificar los datos"); }
            
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void LVUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtUserName.Text = LVUsuarios.FocusedItem.Text;
        }
    }
}
