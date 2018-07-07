using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnicasFundamentalesProyectoFinal
{
    class RegistroCS
    {
        private AlumnosCS _alumno;
        private HashSet<MateriaCS> _materias;
        private List<int> _calificaciones;

        public RegistroCS(AlumnosCS alumno)
        {
            _alumno = alumno;
        }
        public void AgregarCalificacion(List<MateriaCS> materias, List<int> calificaciones)
        {
            foreach (var item in materias)
            {
                _materias.Add(item);
            }
            foreach (var item in calificaciones)
            {
                _calificaciones.Add(item);
            }
        }
        public AlumnosCS Alumno { get { return _alumno; } }

        public HashSet<MateriaCS> GetMaterias() => _materias;

        public List<int> GetCalificaciones() => _calificaciones;
    }
}
