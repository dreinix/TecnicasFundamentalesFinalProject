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
            BtGuardar.Enabled = false;
        }

        private void materialLabel3_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void materialSingleLineTextField2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSeparator(e.KeyChar))
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
            try
            {
                DataBaseControl DbControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
                string[] parameters = { "@id", "@nombre", "@credito" };
                string[] values = { TxtClave.Text, TxtNombre.Text, CBCredito.SelectedItem.ToString() };
                if (DbControl.Insertar("Insert into [Materias] values(@id,@nombre,@credito)", parameters, values))
                {
                    MessageBox.Show(string.Format("{0} agregado", TxtNombre.Text));
                    TxtClave.Clear();
                    TxtNombre.Clear();
                    CBCredito.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show(string.Format("{0} no agregado", TxtNombre.Text));
                }
            }
            catch (Exception) { MessageBox.Show("Por favor, verifique los datos"); }
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBCredito.SelectedIndex>=0 && TxtClave.TextLength > 0 && TxtNombre.TextLength > 0)
            {
                BtGuardar.Enabled = true;
            }
            else
            {
                BtGuardar.Enabled = false;
            }
        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {
            if (CBCredito.SelectedIndex >= 0 && TxtClave.TextLength > 0 && TxtNombre.TextLength>0)
            {
                BtGuardar.Enabled = true;
            }
            else
            {
                BtGuardar.Enabled = false;
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (CBCredito.SelectedIndex >= 0 && TxtClave.TextLength > 0 && TxtNombre.TextLength > 0)
            {
                BtGuardar.Enabled = true;
            }
            else
            {
                BtGuardar.Enabled = false;
            }
        }

        private void TxtNombre_Click(object sender, EventArgs e)
        {

        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)|| char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
    }
}
