using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnicasFundamentalesProyectoFinal
{
    class MateriaCS
    {
        private String _nombre;
        private String _codigo;
        private int _ID;
        private String _area;
        private string _areaCode = "AAA";

        public string Nombre
        {
            get { return _nombre; }
        }
        public string Codigo
        {
            get { return _codigo; }
        }
        public int ID
        {
            get { return _ID; }
        }
        public string Area
        {
            get { return _area; }
        }
        public string AreaCode
        {
            get { return _areaCode; }
        }
        public static int GenerarID()
        {
            string iD = "";
            Random r1 = new Random();
            iD = "" + r1.Next(0000, 10000);
            return int.Parse(iD);
        }

        public MateriaCS CreateMateria(string nombre, string codigo, int ID, string area, string areaCode)
        {
            MateriaCS materia = new MateriaCS();
            materia._nombre = nombre;
            materia._codigo = codigo;
            materia._ID = ID;
            materia._area = area;
            materia._areaCode = areaCode;
            return materia;
        }
    }
}
