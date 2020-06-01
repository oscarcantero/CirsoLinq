using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Linq.Entidades
{
   public class Estudiante
    {
        public int EstudianteId { get; set; }
        public int CursoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool Activo { get; set; }

    }
}
