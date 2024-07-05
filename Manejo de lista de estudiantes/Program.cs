using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_de_lista_de_estudiantes
{
    internal class Program
    {
        static void Main()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            AgregarEstudiantes(estudiantes);

            var mayoresDeEdad = estudiantes.FindAll(e => e.Edad > 18);
            Console.WriteLine("Estudiantes mayores de 18 años:");
            ImprimirEstudiantes(mayoresDeEdad);

            var estudianteNotaAlta = estudiantes.OrderByDescending(e => e.Nota).FirstOrDefault();
            if (estudianteNotaAlta != null)
            {
                Console.WriteLine($"\nEstudiante con la nota más alta:");
                ImprimirEstudiante(estudianteNotaAlta);
            }

            var estudiantesOrdenados = estudiantes.OrderBy(e => e.Nombre).ToList();
            Console.WriteLine("\nEstudiantes ordenados por nombre:");
            ImprimirEstudiantes(estudiantesOrdenados);

            var promedioNotas = estudiantes.Average(e => e.Nota);
            Console.WriteLine($"\nPromedio de notas de los estudiantes: {promedioNotas:F2}");
        }

        static void AgregarEstudiantes(List<Estudiante> estudiantes)
        {
            estudiantes.Add(new Estudiante { Nombre = "Mick", Edad = 18, Nota = 6.0 });
            estudiantes.Add(new Estudiante { Nombre = "Gerald", Edad = 21, Nota = 5.0 });
            estudiantes.Add(new Estudiante { Nombre = "Ricardo", Edad = 18, Nota = 4.8 });
            estudiantes.Add(new Estudiante { Nombre = "Anuar", Edad = 23, Nota = 3.0 });
            estudiantes.Add(new Estudiante { Nombre = "Bryan", Edad = 25, Nota = 8.5 });
        }

        static void ImprimirEstudiantes(List<Estudiante> estudiantes)
        {
            estudiantes.ForEach(e => Console.WriteLine($"{e.Nombre}, Edad: {e.Edad}, Nota: {e.Nota}"));
        }

        static void ImprimirEstudiante(Estudiante estudiante)
        {
            Console.WriteLine($"{estudiante.Nombre}, Edad: {estudiante.Edad}, Nota: {estudiante.Nota}");
        }
    }
}
