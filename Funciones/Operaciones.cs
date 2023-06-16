using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hola_mundo.Funciones
{
    public  class Operaciones
    {
        public int SumaDosnumeros(int num1, int num2)

        {
            int result = num1 + num2;
            return result;

        }

        public int Resta(int num1, int num2)

        {
            int result = num1 - num2;
            return result;

        }

        public int Multiplicacion(int num1, int num2)

        {
            int result = num1 * num2;
            return result;

        }

        public int Division(int num1, int num2)

        {
            int result = num1 / num2;
            return result;

        }

        public void SumaVoid(int num1, int num2) 
        {
            Console.WriteLine("Ingresa un numero");
            num1 = int.Parse(Console.ReadLine());
        }
    }

    
}
