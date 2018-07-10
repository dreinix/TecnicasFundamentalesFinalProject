using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal.Agregar
{
    public partial class AgregarMaestroForm : Material
    {
        public AgregarMaestroForm()
        {
            InitializeComponent();
        }

        private void AgregarMateriasForm_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new System.IO.MemoryStream();
                PBImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                DataBaseControl DbControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
                string[] parameters = { "@id", "@nombre", "@image" };
                string[] values = { TxtID.Text, TxtNombre.Text};
                if (DbControl.Insertar("Insert into Maestros values (@id,@nombre,@image)", parameters, values,ms))
                {
                    MessageBox.Show("{0} agregado", TxtNombre.Text);
                }
                else
                {
                    MessageBox.Show("{0} no agregado", TxtNombre.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, revisar los valores agregados");
            }            
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PBImage.Image = Image.FromFile(dialog.FileName);
            }
            PBImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
