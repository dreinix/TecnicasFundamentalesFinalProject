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
    public partial class AgregarRegistroForm : Material
    {
        public AgregarRegistroForm()
        {
            InitializeComponent();
        }
        private bool Verificar()
        {
            if (CBAlumno.SelectedItem != null && CBMateria.SelectedItem != null)
                return true;
            else
                return false;
        }
        private void AgregarRegistroForm_Load(object sender, EventArgs e)
        {
            if (Verificar())
            {
                BtVincular.Enabled = true;
            }
            else
            {
                BtVincular.Enabled = false;
            }
            DataBaseControl DbControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            string[] para = new string[] { "@algo" };
            string[] val = new string[] { " " };
            List<string[]> alumnos = DbControl.Buscar("Select [ID] from Alumnos where [ID]!=@algo",para,val,1);
            foreach (string[] list in alumnos)
            {
                foreach (string objeto in list)
                {
                    CBAlumno.Items.Add(objeto);
                }
            }
            para = new string[] { "@algo" };
            val = new string[] { " " };
            List<string[]> Materias = DbControl.Buscar("Select [Clave] from Materias where [Clave]!=@algo", para, val, 1);
            foreach (string[] list in Materias)
            {
                foreach (string objeto in list)
                {
                    CBMateria.Items.Add(objeto);
                }
            }
        }

        private void BtVincular_Click(object sender, EventArgs e)
        {
            try
            {
                bool keep = true;

                DataBaseControl DbControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
                string[] parameters = { "@word" };
                string[] value = { CBAlumno.SelectedItem.ToString() };

                keep = DbControl.Buscar("Select * from Alumnos where [ID] = @word", parameters, value);
                if (keep)
                {
                    parameters = new string[] { "@word" };
                    value = new string[] { CBMateria.SelectedItem.ToString() };
                    keep = DbControl.Buscar("Select * from Materias where [Clave] = @word", parameters, value);
                    if (!keep)
                    {
                        keep = false;
                    }
                }

                if (keep == false)
                {
                    MessageBox.Show("Es imposible vincular una materia a un estudiante si uno de los dos no existe");
                }
                else
                {
                    string[] Parameters = new string[] { "@Alm", "@Mat" };
                    string[] values = new string[] { CBAlumno.SelectedItem.ToString(), CBMateria.SelectedItem.ToString() };
                    if (!DbControl.Buscar("Select * from [Registro] where [Alumno] = @Alm and [Materia] = @Mat", Parameters, values))
                    {
                        DbControl.Insertar("Insert into  [Registro] ([Alumno],[Materia]) values (@Alm,@Mat)", Parameters, values);
                        
                        MessageBox.Show(string.Format("{0} fue inscrito en {1}", CBMateria.SelectedItem.ToString(), CBMateria.SelectedItem.ToString()));
                        CBAlumno.SelectedItem = null;
                        CBMateria.SelectedItem = null;
                        Verificar();
                    }
                    else
                    {
                        MessageBox.Show("El alumno ya está inscrito en esta materia");
                    }


                }
            }
            catch (Exception) { MessageBox.Show("Por favor, verifique los datos"); }
            
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Verificar())
            {
                BtVincular.Enabled = true;
            }
            else
            {
                BtVincular.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Verificar())
            {
                BtVincular.Enabled = true;
            }
            else
            {
                BtVincular.Enabled = false;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
