using EjerciosPracticaUno.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciosPracticaUno.Ejercicios
{
    public class EjercicioPersona
    {
        Persona persona;
        List<string> nombre;
        List<float> altura;
        float sumAltura;
        int cantPersona;
        public EjercicioPersona()
        {
            persona = new();
            nombre = new();
            altura = new();
            sumAltura = new();
            cantPersona = new();
        }

        public void RegistrarPersona()
        {
            
            Console.WriteLine("Ingrese la cantidad de Personas a registrar:");
            cantPersona = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantPersona; i++)
            {
                Console.WriteLine("Nombre: \n");
                nombre.Add(Console.ReadLine());
                Console.WriteLine("Altura (En metros): \n");
                altura.Add(float.Parse(Console.ReadLine()));
            }
            persona.Nombres = nombre.ToArray();
            persona.Altura = altura.ToArray();
            for (int i = 0; i < persona.Altura.Length; i++)
            {
                sumAltura += persona.Altura[i];
            }
            float prom = sumAltura / persona.Altura.Length;
            Debug.WriteLine(prom);
            Console.WriteLine($"El promedio de la altura de las {persona.Altura.Length} personas es: {prom}");
        }
    }
}
