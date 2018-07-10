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
        private int _credito;

        public string Nombre
        {
            get { return _nombre; }
        }
        public string Codigo
        {
            get { return _codigo; }
        }
        public int Credito
        {
            get { return _credito; }
        }

        public MateriaCS (string nombre, string codigo, int credito, string area, string areaCode)
        {
            _nombre = nombre;
            _codigo = codigo;
            _credito = credito;
        }
    }
}
