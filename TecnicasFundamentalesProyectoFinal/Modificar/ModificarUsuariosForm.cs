using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicasFundamentalesProyectoFinal.Modificar
{
    public partial class BTActualizar : Material
    {
        public BTActualizar()
        {
            InitializeComponent();
        }

        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private SqlConnection con = new SqlConnection();
        private BindingSource Source = new BindingSource();

        private void ModificarUsuariosForm_Load(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            string[] parameters = { "@word" };
            string[] value = { TxtBuscar.Text };
            DataTable table = new DataTable();
            string cPath = System.IO.Directory.GetCurrentDirectory() + @"\";
            //public static string cPath = Path.GetFullPath(@"..\..\");
            string _location = "", _DataBaseName = "ProjectDataBase.mdf";

            _location = cPath + _DataBaseName;
            String path = @"Data source = (localDB)\MSSQLLocalDB ; AttachDbFilename=" + _location + ";Integrated Security=SSPI";
            con.ConnectionString = path;
            con.Open();
            using (dataAdapter)
            {
                dataAdapter = new SqlDataAdapter("Select * from [Users] where [UserName]=0", con);
                for (int i = 0; i < parameters.Length; i++)
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue(parameters[i], value[i]);
                }
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
            }
            Source.DataSource = table;
            DGVUsuarios.DataSource = Source;
            DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            string[] parameters = { "@word" };
            string[] value = { TxtBuscar.Text };
            DataTable table = new DataTable();
            string cPath = System.IO.Directory.GetCurrentDirectory() + @"\";
            //public static string cPath = Path.GetFullPath(@"..\..\");
            string _location = "", _DataBaseName = "ProjectDataBase.mdf";

            _location = cPath + _DataBaseName;
            String path = @"Data source = (localDB)\MSSQLLocalDB ; AttachDbFilename=" + _location + ";Integrated Security=SSPI";
            con.ConnectionString = path;
            con.Open();
            using (dataAdapter)
            {
                dataAdapter = new SqlDataAdapter("Select * from Users where [UserName] = @word", con);
                for (int i = 0; i < parameters.Length; i++)
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue(parameters[i], value[i]);
                }
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
            }
            Source.DataSource = table;
            DGVUsuarios.DataSource = Source;
            DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update((DataTable)Source.DataSource);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
