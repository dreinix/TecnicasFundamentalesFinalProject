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
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            string[] parameters = { "@word" };
            string[] value = { TxtBuscar.Text };
            DataTable table = new DataTable();
            String path = @"Data source = (localDB)\MSSQLLocalDB ; AttachDbFilename=" + DataBaseControl.cPath + "ProjectDataBase.mdf" + ";Integrated Security=SSPI";
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
            DataBaseControl DBControl = new DataBaseControl(DataBaseControl.cPath, "ProjectDataBase.mdf");
            string[] parameters = { "@word" };
            string[] value = { TxtBuscar.Text };
            DataTable table = new DataTable();
            String path = @"Data source = (localDB)\MSSQLLocalDB ; AttachDbFilename=" + DataBaseControl.cPath + "ProjectDataBase.mdf" + ";Integrated Security=SSPI";
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
                {
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
                    String path = @"Data source = (localDB)\MSSQLLocalDB ; AttachDbFilename=" + DataBaseControl.cPath + "ProjectDataBase.mdf" + ";Integrated Security=SSPI";
                    con.ConnectionString = path;
                    con.Open();
                    for (int i = 0; i < DGVREgistro.Rows.Count; i++)
                    {
                        using(SqlCommand cmd = new SqlCommand("Update [Registro] set [Alumno]=@alumno, [Materia] = @materia,[Calificacion]=@cal,[CalificacionLiteral] = @calLit where [Alumno]=@alumno and [Materia]=@materia", con))
                        {
                            cmd.Parameters.AddWithValue("@alumno", DGVREgistro.CurrentRow.Cells[0].Value);
                            cmd.Parameters.AddWithValue("@materia", DGVREgistro.CurrentRow.Cells[1].Value);
                            cmd.Parameters.AddWithValue("@cal", DGVREgistro.CurrentRow.Cells[2].Value);
                            cmd.Parameters.AddWithValue("@calLit", DGVREgistro.CurrentRow.Cells[3].Value);
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
