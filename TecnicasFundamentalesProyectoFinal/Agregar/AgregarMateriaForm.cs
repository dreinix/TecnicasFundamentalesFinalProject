using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal.Agregar
{
    public partial class AgregarMateriaForm : Material
    {
        public AgregarMateriaForm()
        {
            InitializeComponent();
        }

        private void AgregarMateriaForm_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void materialSingleLineTextField3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void materialSingleLineTextField2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            DataBaseControl DbControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            string[] parameters = { "@id", "@nombre", "@credito" };
            string[] values = { TxtClave.Text, TxtNombre.Text, TxtCredito.Text };
            if (DbControl.Insertar("Insert into [Materias] values(@id,@nombre,@credito)", parameters, values))
            {
                MessageBox.Show(string.Format("{0} agregado", TxtNombre.Text));
            }
            else
            {
                MessageBox.Show(string.Format("{0} no agregado", TxtNombre.Text));
            }
        }
    }
}
