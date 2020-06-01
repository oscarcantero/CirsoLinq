using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Curso_Linq.Entidades;

namespace Curso_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            var cursos = Data.GetCursos();
            var estudiantes = Data.GetEstudiantes();

            //var cursosFiltrado = from c in cursos
            //                     where c.Activo==true
            //                     select c;

            var cursosFiltrado = cursos.Where(x => x.Activo && x.FechaInicio?.Year == 2021);

            var cursosFiltrado2 = cursos.Where(x => x.Activo).Where(x=> x.FechaInicio?.Year == 2021);

            var estudiantesFiltrado = estudiantes.Where(x=> x.Activo==true);


            Console.WriteLine(" --  CURSOS Filtrado-- ");
            foreach (var item in cursosFiltrado)
            {
                Console.WriteLine($"{item.Codigo} - {item.Nombre}");
            }
            Console.WriteLine();
            Console.WriteLine(" --  ESTUDIANTES Filtrado-- ");
            foreach (var item in estudiantesFiltrado)
            {
                Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido}");
            }

            Console.WriteLine("=======================================================");


            Console.WriteLine(" --  CURSOS -- ");
            foreach (var item in cursos)
            {
                Console.WriteLine($"{item.Codigo} - {item.Nombre}");
            }
            Console.WriteLine();
            Console.WriteLine(" --  ESTUDIANTES-- ");
            foreach (var item in estudiantes)
            {
                Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido}");
            }



            //int[] arreglo = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] arreglo2 = new int[3];

            //List<string> ListString = new List<string>() { new string ("Maria" ), new string("roberto") };



            //var nombres = ListString.Where(p => p.StartsWith("M"));

            //foreach (var item in nombres)
            //{
            //    Console.WriteLine(item);

            //}

            //var consulta = from a in ListString
            //               select a;

            //foreach( var a in ListString)
            //{
            //    Console.Write(a);
            //}
            //Console.WriteLine("===============");

            //foreach (var b in consulta)
            //{
            //    Console.WriteLine(b);
            //}



            Console.ReadLine();
        }
    }
}
