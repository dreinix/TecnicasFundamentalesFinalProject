using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnicasFundamentalesProyectoFinal
{
    class AlumnosCS
    {   
        private String _nombre;
        private String _apellido;
        private String _estado;
        private int _ID;
        private String _carrera;
        private String _identificadorPersonal;
        private string _fechaNacimiento;

        public AlumnosCS(string nombre, string apellido, string estado, int ID, string carrera, string identificadorPersonal, string fechaNacimiento)
        {
            _nombre = nombre;
            _apellido = apellido;
            _estado = estado;
            _ID = ID;
            _carrera = carrera;
            _identificadorPersonal = identificadorPersonal;
            _fechaNacimiento = fechaNacimiento;
        }

        public string FechaNacimiento
        {
            get { return _fechaNacimiento; }
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public string Apellido
        {
            get { return _apellido; }
        }
        public string Estado
        {
            get { return _estado; }
        }
        public int ID
        {
            get { return _ID; }
        }
        public string Carrera
        {
            get { return _carrera; }
        }
        public string IdentificadorPersonal
        {
            get { return _identificadorPersonal; }
        }
        public static int GenerarID()
        {
            string yearIdentiffier = DateTime.Today.Year.ToString(), currentId = yearIdentiffier[2] + "0" + yearIdentiffier[3];
            string iD = "";
            Random r1 = new Random();
            iD = currentId + "" + r1.Next(1001, 10000);
            return int.Parse(iD);
        }
    }

}
