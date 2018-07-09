using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal
{
    public partial class CrearAlumnoForm : MaterialForm
    {
        public CrearAlumnoForm()
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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
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
                AlumnosCS estudiante = new AlumnosCS(TxtNombre.Text, TxtApellido.Text, comboBox1.Text, id, TxtCarrera.Text, TxtIdentificadorNacial.Text, DateTime.Parse(maskedTextBox1.Text).ToShortDateString());
                string[] Elements = new string[] { "@id", "@nombre", "@apellido", "@fecha", "@identifacor", "@estado", "@carrera" };
                string[] Values = new string[]  { estudiante.ID.ToString(), estudiante.Nombre, estudiante.Apellido, estudiante.FechaNacimiento.ToString(), estudiante.IdentificadorPersonal, estudiante.Estado, estudiante.Carrera };
                
                if(DBcontrol.Insertar("Insert into Alumnos values(@id,@nombre,@apellido,@fecha,@identifacor,@estado,@carrera)", Elements, Values))
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
    }
}
