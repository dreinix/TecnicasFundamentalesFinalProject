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
    public partial class ModificarMateriasForm : Material
    {
        public ModificarMateriasForm()
        {
            InitializeComponent();
        }
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private SqlConnection con = new SqlConnection();
        private BindingSource Source = new BindingSource();

        private void ModificarMateriasForm_Load(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            string[] parameters = { "@word" };
            string[] value = { TxtFiltrar.Text };
            DataTable table = new DataTable();
            string cPath = System.IO.Directory.GetCurrentDirectory() + @"\";
            //public static string cPath = Path.GetFullPath(@"..\..\");
            string _location = "", _DataBaseName = "ProjectDataBase.mdf";

            _location = cPath + @"ApplicationData\" + _DataBaseName;
            String path = @"Data source = (localdb)\v11.0 ; AttachDbFilename=" + _location + "; MultipleActiveResultSets=True; Integrated Security=SSPI";
            con.ConnectionString = path;
            con.Open();
            using (dataAdapter)
            {
                dataAdapter = new SqlDataAdapter("Select * from Materias", con);
                for (int i = 0; i < parameters.Length; i++)
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue(parameters[i], value[i]);
                }
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
            }
            Source.DataSource = table;
            DGVAlumnos.DataSource = Source;
            DGVAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            

            try
            {
                dataAdapter.Update((DataTable)Source.DataSource);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TxtFiltrar_TextChanged(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf");
            string[] parameters = { "@word" };
            string[] value = { TxtFiltrar.Text };
            DataTable table = new DataTable();
            string cPath = System.IO.Directory.GetCurrentDirectory() + @"\";
            //public static string cPath = Path.GetFullPath(@"..\..\");
            string _location = "", _DataBaseName = "ProjectDataBase.mdf";

            _location = cPath + @"ApplicationData\" + _DataBaseName;
            String path = @"Data source = (localdb)\v11.0 ; AttachDbFilename=" + _location + "; MultipleActiveResultSets=True; Integrated Security=SSPI";
            con.ConnectionString = path;
            con.Open();
            using (dataAdapter)
            {
                dataAdapter = new SqlDataAdapter("Select * from Materias where [Clave] like '%'+@word+'%' or [Nombre] like '%'+@word+'%' ", con);
                for (int i = 0; i < parameters.Length; i++)
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue(parameters[i], value[i]);
                }
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
            }
            Source.DataSource = table;
            DGVAlumnos.DataSource = Source;
            DGVAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }
    }
}
