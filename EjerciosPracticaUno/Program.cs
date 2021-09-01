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
            Console.WriteLine($"Escoge el ejercicio a realizar \n");
            Console.WriteLine($"1) Lista edades Estudiante \n" +
                $"5) Parcial");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
                ejercicioEstudiante.RegistrarEdadEstudiantes();
            else if (opcion == 5)
                ejercicioParcial.RegistrarEmpleado();

            else
                Console.WriteLine("Ingresa una opcion Valida por favor. \n");
        }
    }
}
