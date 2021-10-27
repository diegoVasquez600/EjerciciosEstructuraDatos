using EjerciosPracticaUno.Ejercicios;
using EjerciosPracticaUno.Models;
using System;

namespace EjerciosPracticaUno
{
    class Program
    {
        static void Main()
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
                $"4) Lista Edades estudiantes (Dinamica)\n" +
                $"5) Parcial\n" +
                $"6) Recursividad (Extra)\n" +
                $"7) Operaciones Matematicas");
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
                Console.WriteLine("Ingrese el numero a dividir: ");
                var num = int.Parse(Console.ReadLine());
                ejercicioRecursividad.Calcular(num);
            }else if(opcion == 7)
            {
                Operacion operacion = new();
                Console.WriteLine("A continuacion ingresa dos valores enteros X, Y y se calcularan las operaciones matematicas entre estos numeros");
                Console.WriteLine("X = ");
                operacion.X = int.Parse(Console.ReadLine());
                Console.WriteLine("Y = ");
                operacion.Y = int.Parse(Console.ReadLine());
                EjercicioOperacionesMatematicas.Calcular(operacion);
                Console.ReadKey();
            }
            else
                Console.WriteLine("Ingresa una opcion Valida por favor. \n");
            Main();
        }
    }
}
