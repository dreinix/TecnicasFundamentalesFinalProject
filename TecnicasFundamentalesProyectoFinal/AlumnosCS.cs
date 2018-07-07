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
        private DateTime _fechaNacimiento;


        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
        }
        public string nombre
        {
            get { return _nombre; }
        }
        public string apellido
        {
            get { return _apellido; }
        }
        public string estado
        {
            get { return _estado; }
        }
        public int ID
        {
            get { return _ID; }
        }
        public string carrera
        {
            get { return _carrera; }
        }
        public string identificadorPersonal
        {
            get { return _identificadorPersonal; }
        }
        public AlumnosCS CreateAlumno(string nombre, string apellido, string estado, int ID, string carrera, string identificadorPersonal, DateTime fechaNacimiento)
        {
            AlumnosCS alumno = new AlumnosCS();
            alumno._nombre = nombre;
            alumno._apellido = apellido;
            alumno._estado = estado;
            alumno._ID = ID;
            alumno._carrera = carrera;
            alumno._identificadorPersonal = identificadorPersonal;
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");
            alumno._fechaNacimiento = fechaNacimiento;
            return alumno;
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
