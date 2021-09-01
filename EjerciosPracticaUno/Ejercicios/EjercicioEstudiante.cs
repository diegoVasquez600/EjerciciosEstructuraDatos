using EjerciosPracticaUno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciosPracticaUno.Ejercicios
{
    public class EjercicioEstudiante
    {
        Estudiante estudiante;
        List<string> nombre;
        List<int> edad;
        int cantEstudiantes;

        public EjercicioEstudiante()
        {
            estudiante = new();
            nombre = new();
            edad = new();
            cantEstudiantes = new();
        }

        public void RegistrarEdadEstudiantes()
        {
            Console.WriteLine("Ingrese la cantidad de estudiantes a registrar:");
            cantEstudiantes = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantEstudiantes; i++)
            {
                Console.WriteLine("Nombre: \n");
                nombre.Add(Console.ReadLine());
                Console.WriteLine("Edad: \n");
                edad.Add(int.Parse(Console.ReadLine()));
            }
            estudiante.Nombres = nombre.ToArray();
            estudiante.Edades = edad.ToArray();
            for (int i = 0; i < estudiante.Nombres.Length; i++)
            {
                Console.WriteLine($"Nombre: {estudiante.Nombres[i]}  Edad: {estudiante.Edades[i]} \n");
            }
            Console.ReadKey();
        }
    }
}
