using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Linq.Entidades
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaInicio { get; set; }
        public bool Activo { get; set; }
    }
}
