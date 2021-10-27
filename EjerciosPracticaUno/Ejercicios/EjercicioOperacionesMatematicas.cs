using EjerciosPracticaUno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciosPracticaUno.Ejercicios
{
    public class EjercicioOperacionesMatematicas
    {
        public static void Calcular(Operacion operacion)
        {
            Sumar(operacion);
            Restar(operacion);
            Multiplicar(operacion);
            Dividir(operacion);
        }

        private static void Sumar(Operacion operacion)
        {
            Console.WriteLine($"El resultado de la Suma es : {operacion.X + operacion.Y}");
        }

        private static void Restar(Operacion operacion)
        {
            Console.WriteLine($"El resultado de la Resta es : {operacion.X - operacion.Y}");
        }

        private static void Multiplicar(Operacion operacion)
        {
            Console.WriteLine($"El resultado de la Multiplicacion es : {operacion.X * operacion.Y}");
        }

        private static void Dividir(Operacion operacion)
        {
            Console.WriteLine($"El resultado de la Division es : {operacion.X / operacion.Y}");
        }
    }
}
