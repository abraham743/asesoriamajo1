using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hola_mundo.Funciones
{
    public class Menu
    {
        public void Menu1() 
        {
            Console.WriteLine("Ingresa un numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;
            Console.WriteLine("Ingresa una de las opciones");
            Console.WriteLine("1) Suma");
            Console.WriteLine("2) Resta");
            Console.WriteLine("3) Divicion");
            Console.WriteLine("4) Multiplicacion");

            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    resultado = (num1 + num2);
                    Console.WriteLine("El resultado de la suma es " + resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es " + resultado);
                    break;

                case 3:
                    resultado = num1 / num2;
                    Console.WriteLine("El resultado de la divicion es" + resultado);
                    break;
                case 4:
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicacion" + resultado);
                    break;
                default:
                    Console.WriteLine("no tengo las opciones");
                    break;

            }
        }   
    }
}
