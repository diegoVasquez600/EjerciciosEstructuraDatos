using EjerciosPracticaUno.Ejercicios;
using System;

namespace EjerciosPracticaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            EjercicioEstudiante ejercicioEstudiante = new();
            EjercicioParcial ejercicioParcial = new();
            EjercicioPersona ejercicioPersona = new();
            EjercicioRecursividad ejercicioRecursividad = new();
            EjercicioElementos ejercicioElementos = new();
            Console.WriteLine($"Escoge el ejercicio a realizar \n");
            Console.WriteLine($"1) Lista edades Estudiante\n" +
                $"2) Promedio altura Personas\n" +
                $"3) Ejercicio Elementos\n" +
                $"4) Lista Edades estudiantes (Dinamica)" +
                $"5) Parcial\n" +
                $"6) Recursividad (Extra)\n");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
                ejercicioEstudiante.RegistrarEdadEstudiantes();
            else if (opcion == 2)
                ejercicioPersona.RegistrarPersona();
            else if (opcion == 3)
                ejercicioElementos.RegistrarElementos();
            else if (opcion == 4)
                ejercicioEstudiante.RegistrarEdadEstudiantes();
            else if (opcion == 5)
                ejercicioParcial.RegistrarEmpleado();
            else if (opcion == 6)
            {
                Console.WriteLine("Ingrese el nuemero a dividir: ");
                var num = int.Parse(Console.ReadLine());
                ejercicioRecursividad.Calcular(num);
            }
            else
                Console.WriteLine("Ingresa una opcion Valida por favor. \n");
        }
    }
}
