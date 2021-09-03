using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciosPracticaUno.Ejercicios
{
    public class EjercicioRecursividad
    {
        int _numero;
        public EjercicioRecursividad()
        {
            _numero = 0;
        }

        public void Calcular(int numero)
        {
            _numero = numero;
            Console.WriteLine($"{_numero}");
            _numero /= 2;
            if (_numero != 0)
                Calcular(_numero);
            else
                Console.WriteLine($"{_numero}");
        }
    }
}
