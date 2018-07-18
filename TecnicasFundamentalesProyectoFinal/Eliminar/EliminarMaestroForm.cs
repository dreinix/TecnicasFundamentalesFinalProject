using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal.Eliminar
{
    public partial class EliminarMaestroForm : Material
    {
        public EliminarMaestroForm()
        {
            InitializeComponent();
        }

        private void EliminarMaestroForm_Load(object sender, EventArgs e)
        {

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
                string[] para = { "@user" };
                string[] ele = { TxtUserName.Text };
                if (DBControl.Eliminar("Delete from Maestros where [ID] = @user", para, ele))
                {
                    MessageBox.Show("Maestro eliminado con exito");
                    LVUsuarios.Clear();
                }
                else
                {
                    MessageBox.Show("Error al eliminar maestro");
                }
            }
            catch (Exception) { MessageBox.Show("Por favor, verificar los datos"); }
            
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            if (TxtUserName.Text.Length > 0)
            {
                DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
                LVUsuarios.Clear();
                string[] _parameters = { "@userN" };
                string[] _element = { TxtUserName.Text };
                string[] _returned = { "UserName" };

                foreach (string[] item in DBControl.Buscar("Select [ID] from [Maestros] where [ID] like '%' + @userN + '%'", _parameters, _element, 1))
                {
                    foreach (var it in item)
                    {
                        LVUsuarios.Items.Add(new ListViewItem(it));
                    }

                }
            }
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
