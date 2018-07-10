using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal
{
    public partial class AgregarAlumnoForm : Material
    {
        public AgregarAlumnoForm()
        {
            InitializeComponent();
        }

        private void CrearAlumnoForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            try
            { 
                DataBaseControl DBcontrol = new DataBaseControl(DataBaseControl.cPath, "ProjectDatabase.mdf");
                int id = AlumnosCS.GenerarID();
                string[] Element = { "@id" };
                string[] values = { id.ToString() };
                string tempID = DBcontrol.BuscarElemento("Select [ID] from Alumnos where [ID] = @id", Element, values);
                while (tempID != "No encontrado")
                {   id = AlumnosCS.GenerarID(); 
                    values = new string[] { id.ToString() };
                    tempID = DBcontrol.BuscarElemento("Select [ID] from Alumnos where [ID] = @id", Element, values);
                }
                MemoryStream ms = new System.IO.MemoryStream();
                PBImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                AlumnosCS estudiante = new AlumnosCS(TxtNombre.Text, TxtApellido.Text, comboBox1.Text, id, TxtCarrera.Text, TxtIdentificadorNacial.Text, DateTime.Parse(maskedTextBox1.Text).ToShortDateString());
                string[] Elements = new string[] { "@id", "@nombre", "@apellido", "@fecha", "@identifacor", "@estado", "@carrera" ,"@image"};
                string[] Values = new string[]  { estudiante.ID.ToString(), estudiante.Nombre, estudiante.Apellido, estudiante.FechaNacimiento.ToString(), estudiante.IdentificadorPersonal, estudiante.Estado, estudiante.Carrera};
                
                if(DBcontrol.Insertar("Insert into Alumnos values(@id,@nombre,@apellido,@fecha,@identifacor,@estado,@carrera,@image)", Elements, Values,ms))
                {
                    Console.WriteLine(MessageBox.Show(string.Format("{0} fue agregado", estudiante.Nombre)));
                }
                else { Console.WriteLine(MessageBox.Show(string.Format("{0} no agregado", estudiante.Nombre)));}
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
                   
        }

        private void TxtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
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
    }
}
