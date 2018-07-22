using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace TecnicasFundamentalesProyectoFinal
{
    public class DataBaseControl
    {
        SqlConnection con = new SqlConnection();

        public static string cPath = Directory.GetCurrentDirectory() + @"\";
        //public static string cPath = Path.GetFullPath(@"..\..\");
        string _location = "";
        SqlCommand cmd = new SqlCommand();
        public static string conectionString = "";
        public DataBaseControl(string _rute, string _DataBaseName) {
            _location = _rute + @"ApplicationData\" + _DataBaseName;
            conectionString = @"Data source = (localdb)\v11.0 ; AttachDbFilename=" + _location + "; MultipleActiveResultSets=True; Integrated Security=SSPI";
        } 

        private void Open()
        {
                try
                {
                    con.Close();
                    //String path = @"Data source = (localDB)\MSSQLLocalDB ; AttachDbFilename=" + _location + ";Integrated Security=SSPI";
                    conectionString = "Data Source = 148.103.246.141,1433;" +
                     "Initial Catalog = ProjectDataBase; User ID=visit;Password=visit";
                    con.ConnectionString = conectionString;
                    con.Open();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
        public void Close() => con.Close();
        public List<SqlDataReader> Buscar(string _query)
        {
            Open();
            List<SqlDataReader> returnList = new List<SqlDataReader>();
            using (cmd = new SqlCommand(_query,con))
            {   
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    returnList.Add(reader);
                }
                Close();
                return returnList;
            }
            
        }
        public List<string[]> Buscar(string _query,string[] _parameters,string[] _elements,int _elementsReturned)
        {
            List<string[]> returnList = new List<string[]>();
            try
            {
                Open();
                using (cmd = new SqlCommand(_query, con))
                {
                    for (int i = 0; i < _elements.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(_parameters[i], _elements[i]);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string[] elementos = new string[_elementsReturned];
                        for (int i = 0; i < _elementsReturned; i++)
                        {
                            elementos[i] = reader[i].ToString();
                        }
                        returnList.Add(elementos);
                    }
                    return returnList;
                }
                
            }
            catch(Exception) {return returnList; }
            
        }
        public bool Buscar(string _query, string[] _parameters, string[] _word)
        {
            try
            {
                Open();
                using (cmd = new SqlCommand(_query, con))
                {
                    for (int i = 0; i < _word.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(_parameters[i], _word[i]);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int founded = 0;
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            for (int a = 0; a < _word.Count(); a++)
                            {
                                if (reader[i].ToString() == _word[a])
                                {
                                    founded += 1;
                                }
                            }

                        }
                        if (founded == _word.Count())
                        {
                            reader.Close();
                            return true;
                        }
                    }
                    reader.Close();
                }
                Close();
                return false;
            }
            catch (Exception) {return false; }


        }
        public string BuscarElemento(string _query, string[] _parameters, string[] _word)
        {
            string value="No encontrado";
            try
            {
                Open();
                using (cmd = new SqlCommand(_query, con))
                {
                    for (int i = 0; i < _word.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(_parameters[i], _word[i]);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        value = reader[0].ToString();

                    }
                    reader.Close();
                }
                Close();
                return value;
            }
            catch (Exception) {return value; }


        }
        public bool Insertar(string _query, string[] _parameters, string[] _word)
        {
            try
            {
                Open();
                using (cmd = new SqlCommand(_query, con))
                {
                    for (int i = 0; i < _parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(_parameters[i], _word[i]);
                    }
                    cmd.ExecuteNonQuery();
                }
                Close();
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        public bool Insertar(string _query, string[] _parameters, string[] _word, MemoryStream image)
        {
            try
            {
                Open();
                using (cmd = new SqlCommand(_query, con))
                {
                    for (int i = 0; i < _word.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(_parameters[i], _word[i]);
                    }
                    cmd.Parameters.AddWithValue(_parameters[_parameters.Length - 1], image.GetBuffer());
                    cmd.ExecuteNonQuery();
                }
                Close();
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }


        }
        public bool Eliminar(string _query,string[] _parameters, string[] _elements)
        {
            try
            {
                Open();
                using(cmd = new SqlCommand(_query,con))
                {   
                    for(int i = 0; i < _parameters.Count(); i++)
                    {
                        cmd.Parameters.AddWithValue(_parameters[i], _elements[i]);
                    }
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                    
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        public DataTable ObtenerTabla(string _query) { 
            try
            {
                Open();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    dataAdapter.SelectCommand = new SqlCommand(_query, con);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    // Populate a new data table and bind it to the BindingSource.
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(table);
                    return table;
                }
                

            }
            catch (Exception) { return null; }
            
        }
        public DataTable ObtenerTabla(string _query, string[] _parameters, string[] _word)
        {
            try
            {
                Open();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    dataAdapter.SelectCommand = new SqlCommand(_query,con);
                    for (int i = 0; i < _parameters.Length; i++)
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue(_parameters[i], _word[i]);
                    }
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    // Populate a new data table and bind it to the BindingSource.
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(table);
                    return table;
                }


            }
            catch (Exception) { return null; }

        }
        public DataTable ActualizarTabla(string _query, string[] _parameters, string[] _word)
        {
            try
            {
                Open();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    dataAdapter.SelectCommand = new SqlCommand(_query, con);
                    for (int i = 0; i < _parameters.Length; i++)
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue(_parameters[i], _word[i]);
                    }
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    // Populate a new data table and bind it to the BindingSource.
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(table);
                    return table;
                }


            }
            catch (Exception) { return null; }

        }
    }
}
