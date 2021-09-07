using EjerciosPracticaUno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciosPracticaUno.Ejercicios
{
    public class EjercicioElementos
    {
        Elemento elemento;
        List<string> nombre;
        List<int> valor;
        int cantElementos;
        int valAcumulado, cantValor20;

        public EjercicioElementos()
        {
            elemento = new();
            nombre = new();
            valor = new();
            cantElementos = new();
            valAcumulado = new();
            cantValor20 = new();
        }

        public void RegistrarElementos()
        {
            Console.WriteLine("Ingrese la cantidad de elementos a registrar:");
            cantElementos = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantElementos; i++)
            {
                Console.WriteLine("Nombre elemento: \n");
                nombre.Add(Console.ReadLine());
                Console.WriteLine("Valor: \n");
                valor.Add(int.Parse(Console.ReadLine()));
                valAcumulado += valor[i];
            }
            elemento.Nombres = nombre.ToArray();
            elemento.Valores = valor.ToArray();
            Console.WriteLine($"El valor acumulado es: {valAcumulado}");
            valAcumulado = 0;
            for (int i = 0; i < elemento.Valores.Length; i++)
            {
                
                if (valor[i] >= 10)
                    valAcumulado += valor[i];
            }
            Console.WriteLine($"El valor acumulado para mayores que 10 es: {valAcumulado}");
            for (int i = 0; i < elemento.Valores.Length; i++)
            {
                valAcumulado = 0;
                if (valor[i] >= 20)
                    cantValor20++;
            }
            Console.WriteLine($"La cantidad de Valores mayor a 20 es: {cantValor20}");
        }
    }
}
