using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TecnicasFundamentalesProyectoFinal
{
    public partial class AgregarUsuarioForm : Material
    {
        string cat;
        public AgregarUsuarioForm(string _cat)
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
            cat = _cat;
            if(cat=="Adm" || cat=="Develop")
            {
                this.Size = new Size(497, 313);
                this.WindowState = FormWindowState.Maximized;
                if (cat != "Develop")
                {
                    CBCat.Items.Remove("Develop");
                }   
            }
            else
            {
                this.Size = new Size(336, 313);
                LbCat.Hide();
                CBCat.Hide();
                cat = "User";
                if (cat != "Develop")
                {
                    CBCat.Items.Remove("Develop");
                }
            }
            this.Sizable = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void MaterialLayout_Load(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            string[] para = { "@id" };
            string[] val = {System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() };
            if(cat!="Adm" || cat != "Develop")
            {
                if (DBControl.Buscar("select * from Activos where [id]=@id", para, val))
                {
                    int activos = int.Parse(DBControl.BuscarElemento("select [registros] from [Activos] where [ID] = @id", para, val));
                    if (activos > 1)
                    {
                        this.Size = new Size(336, 313);
                        LbCat.Hide();
                        CBCat.Hide();
                        cat = "User";
                    }
                    else
                    {
                        this.Size = new Size(497, 313);
                        LbCat.Show();
                        CBCat.Show();
                        cat = "Adm";
                    }
                }
                else
                {
                    string[] nums = { System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString(), "0" };
                    para = new string[] { "@id", "@nums" };
                    if (DBControl.Insertar("Insert into [Activos] values(@id,@nums)", para, nums))
                    {
                        this.Size = new Size(497, 313);
                        LbCat.Show();
                        CBCat.Show();
                        cat = "Adm";
                    }
                    else
                    {
                        MessageBox.Show("Algún error inesperado ha ocurrido, por favor, intente de nuevo");
                        this.Close();
                    }

                }
            }
            
            CBCat.SelectedValue = cat;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
                string[] parameters = { "@userName", "@pass", "cat" };
                string[] elements = { TxtUserName.Text, TxtPass.Text, CBCat.SelectedItem.ToString() };
                if (DBControl.Insertar("insert into Users values(@userName,@pass,@cat)", parameters, elements))
                {
                    string[] para = { "@id" };
                    string[] val = { System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() };
                    int activos = int.Parse(DBControl.BuscarElemento("select [registros] from Activos where [ID] = @id", para, val));
                    para = new string[] { "@id", "@nums" };
                    string[] nums = { System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString(), (++activos).ToString(), };
                    DBControl.Insertar("update [Activos] set [registros]=@nums where [id]=@id", para, nums);
                    
                    MessageBox.Show("Usuario agregado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario no pudo ser agregado");
                }
                DBControl.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Por favor, verifique los datos");
            }
            
            
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBCat_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
