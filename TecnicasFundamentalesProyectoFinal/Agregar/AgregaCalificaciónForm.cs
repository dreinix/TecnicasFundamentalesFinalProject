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

namespace TecnicasFundamentalesProyectoFinal.Agregar
{
    public partial class AgregaCalificaciónForm : Material
    {
        public AgregaCalificaciónForm()
        {
            InitializeComponent();
        }
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private SqlConnection con = new SqlConnection();
        private BindingSource Source = new BindingSource();

        private void AgregaCalificaciónForm_Load(object sender, EventArgs e)
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
                dataAdapter = new SqlDataAdapter("Select * from Registro", con);
                for (int i = 0; i < parameters.Length; i++)
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue(parameters[i], value[i]);
                }
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
            }
            Source.DataSource = table;
            DGVREgistro.DataSource = Source;
            DGVREgistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
            DGVREgistro.Columns[0].ReadOnly = true;
            DGVREgistro.Columns[1].ReadOnly = true;
            DGVREgistro.Columns[3].ReadOnly = true;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath,"ProjectDataBase.mdf.mdf");
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
                dataAdapter = new SqlDataAdapter("Select * from Registro where [Alumno] like '%'+@word+'%' or [Materia] like '%'+@word+'%' ", con);
                for (int i = 0; i < parameters.Length; i++)
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue(parameters[i], value[i]);
                }
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
            }
            Source.DataSource = table;
            DGVREgistro.DataSource = Source;
            DGVREgistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVREgistro.Columns[0].ReadOnly = true;
            DGVREgistro.Columns[1].ReadOnly = true;
            DGVREgistro.Columns[3].ReadOnly = true;
            con.Close();
        }

        private void DGVREgistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DGVREgistro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(DGVREgistro.CurrentRow.Cells[2].Value.ToString(), out int grade))
                {   if(grade>100 || grade < 0)
                    {
                        MessageBox.Show("Imposible agregar una calificación con este valor");
                        DGVREgistro.CurrentRow.Cells[2].Value = "0";
                    }
                    if (grade >= 90)
                    {
                        DGVREgistro.CurrentRow.Cells[3].Value = "A";
                    }
                    else if (grade >= 80)
                    {
                        DGVREgistro.CurrentRow.Cells[3].Value = "B";
                    }
                    else if (grade >= 70)
                    {
                        DGVREgistro.CurrentRow.Cells[3].Value = "C";
                    }
                    else if (grade >= 60)
                    {
                        DGVREgistro.CurrentRow.Cells[3].Value = "D";
                    }
                    else if (grade < 60)
                    {
                        DGVREgistro.CurrentRow.Cells[3].Value = "F";
                    }
                    string cPath = System.IO.Directory.GetCurrentDirectory() + @"\";
                    //public static string cPath = Path.GetFullPath(@"..\..\");
                    string _location = "", _DataBaseName = "ProjectDataBase.mdf";

                    _location = cPath + _DataBaseName;
                    String path = @"Data source = (localDB)\MSSQLLocalDB ; AttachDbFilename=" + _location + ";Integrated Security=SSPI";
                    con.ConnectionString = path;
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("Update [Registro] set [Alumno]=@alumno, [Materia] = @materia,[Calificacion]=@cal,[CalificacionLiteral] = @calLit where [Alumno]=@alumno and [Materia]=@materia", con))
                    {
                        cmd.Parameters.AddWithValue("@alumno", DGVREgistro.CurrentRow.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@materia", DGVREgistro.CurrentRow.Cells[1].Value);
                        cmd.Parameters.AddWithValue("@cal", DGVREgistro.CurrentRow.Cells[2].Value);
                        cmd.Parameters.AddWithValue("@calLit", DGVREgistro.CurrentRow.Cells[3].Value);
                        cmd.ExecuteNonQuery();
                    }
                    float[] suma = new float[200];
                    float[] total = new float[200];
                    string[] para;
                    string[] val;
                    HashSet<string> IDS = new HashSet<string>();
                    for (int i = 0; i < DGVREgistro.Rows.Count; i++)
                    {
                        IDS.Add(DGVREgistro.Rows[i].Cells[0].Value.ToString());
                    }
                    Dictionary<string, int> Evaluar = new Dictionary<string, int>();
                    int a = 0;
                    foreach (string item in IDS)
                    {
                        a++;
                        Evaluar.Add(item, a);
                    }
                    Dictionary<char, int> valores = new Dictionary<char, int>
                    {
                        { 'A', 4 },
                        { 'B', 3 },
                        { 'C', 2 },
                        { 'D', 1 },
                        { 'F', 0 }
                    };
                    DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
                    string LID = DGVREgistro.Rows[0].Cells[0].Value.ToString();
                    suma[0] = 0;
                    total[0] = 0;
                    for (int i = 0; i < DGVREgistro.Rows.Count; i++)
                    {
                        string CID = DGVREgistro.Rows[i].Cells[0].Value.ToString();
                        if (LID!= CID)
                        {
                            LID = DGVREgistro.Rows[i].Cells[0].Value.ToString();
                            total[Evaluar[CID]] = 0;
                            suma[Evaluar[CID]] = 0;
                        }
                        para = new string[] { "@id","alum" };
                        val = new string[] { DGVREgistro.Rows[i].Cells[1].Value.ToString()};
                        int credito = int.Parse(DBControl.BuscarElemento("Select [Credito] from [Materias] where [Clave]=@id", para, val));
                        total[Evaluar[CID]] += credito;
                        string literal;
                        literal = (DGVREgistro.Rows[i].Cells[3].Value.ToString().ToUpper());
                        if (literal.Length < 1)
                        {
                            literal = "F";
                        }
                        string test = "" + literal;
                        suma[Evaluar[CID]] += valores[literal[0]] * credito;
                    }
                    LID = DGVREgistro.Rows[0].Cells[0].Value.ToString();
                    for (int i = 0; i < DGVREgistro.Rows.Count; i++)
                    {
                        string CID = DGVREgistro.Rows[i].Cells[0].Value.ToString();
                        if (LID != DGVREgistro.Rows[i].Cells[0].Value.ToString())
                        {
                            LID = DGVREgistro.Rows[i].Cells[0].Value.ToString();
                        }
                        float notea = (suma[Evaluar[CID]] / total[Evaluar[CID]]);
                        para = new string[] { "@algo" };
                        val = new string[] { DGVREgistro.Rows[i].Cells[0].Value.ToString() };
                        string ID = DBControl.BuscarElemento("Select [ID] from Alumnos where [ID]=@algo", para, val);
                        using (SqlCommand cmd = new SqlCommand("Update [Alumnos] set [Indice]=@nota where [ID]=@alumno", con))
                        {
                            cmd.Parameters.AddWithValue("@alumno", ID);
                            cmd.Parameters.AddWithValue("@nota", notea);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Por favor, digite un número");
                    DGVREgistro.CurrentRow.Cells[2].Value = null; 
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
        }

        private void DGVREgistro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
