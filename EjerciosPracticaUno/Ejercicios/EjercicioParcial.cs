using EjerciosPracticaUno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciosPracticaUno.Ejercicios
{
    public class EjercicioParcial
    {
        Empleado empleado;
        List<string> nombre;
        List<int> salario;
        int cantEmpleados;
        int salarioMayor, salarioAnt;
        public EjercicioParcial()
        {
            empleado = new();
            nombre = new();
            salario = new();
            salarioMayor = new();
            cantEmpleados = new();
        }
        public void RegistrarEmpleado()
        {

            Console.WriteLine("Ingrese la cantidad de Empleados a registrar:");
            cantEmpleados = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantEmpleados; i++)
            {
                Console.WriteLine("Nombre: \n");
                nombre.Add(Console.ReadLine());
                Console.WriteLine("Salario: \n");
                salario.Add(int.Parse(Console.ReadLine()));
            }
            empleado.Nombres = nombre.ToArray();
            empleado.Salario = salario.ToArray();
            for (int i = 0; i < empleado.Nombres.Length; i++)
            {
                int pos;
                salarioAnt = empleado.Salario[i];
                Console.WriteLine($"Nombre: {empleado.Nombres[i]}  Edad: {empleado.Salario[i]} \n");
                if (salarioAnt > salarioMayor)
                {
                    salarioMayor = salarioAnt;
                    pos = i;
                    Console.WriteLine($"El empleado con el mayor salario es {empleado.Nombres[pos]} con un salario de {empleado.Salario[pos]}");
                }

            }
            Console.ReadKey();
        }
    }
}
