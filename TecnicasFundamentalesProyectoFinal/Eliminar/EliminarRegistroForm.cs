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
    public partial class EliminarRegistroForm : Material
    {
        public EliminarRegistroForm()
        {
            InitializeComponent();
        }

        private void EliminarRegistroForm_Load(object sender, EventArgs e)
        {

        }

        private void TxtMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            if (TxtUserName.Text.Length > 0)
            {
                DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
                LVUsuarios.Clear();
                string[] _parameters = { "@userN","@Materia" };
                string[] _element = { TxtUserName.Text,TxtMateria.Text };

                foreach (string[] item in DBControl.Buscar("Select [Materia] from [Registro] where [ID] like '%' + @userN + '%' and [Materia] like '%' + @Materia + '%'", _parameters, _element, 1))
                {
                    foreach (var it in item)
                    {
                        LVUsuarios.Items.Add(new ListViewItem(it));
                    }

                }
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            string[] _parameters = { "@userN", "@Materia" };
            string[] _element = { TxtUserName.Text, TxtMateria.Text };
            if (DBControl.Eliminar("Select from [Registro] where [ID] like '%' + @userN + '%' and [Materia] like '%' + @Materia + '%'", _parameters, _element))
            {
                MessageBox.Show("Registro eliminado con exito");
                LVUsuarios.Clear();
            }
            else
            {
                MessageBox.Show("Error al eliminar usuario");
            }

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
