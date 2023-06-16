using hola_mundo.Funciones;
using System;

namespace hola_mundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region ------Variables-------
            //int num1, num2, result = 0;
            //string mensaje = "Hola mundo";
            //Console.WriteLine("La suma de dos numeros");
            //Console.WriteLine("Ingresa un numero");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingresa otro numero");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("El resultado es:");
            //result = num1 + num2;

            //Console.WriteLine(result);
            #endregion
            #region ---Constante----
            //const double numero = 3.1416;

            //Console.WriteLine(numero);
            #endregion

            Operaciones operaciones = new Operaciones();
            
            Menu menu = new Menu();
            menu.Menu1();
        }

      

        //string opcion = Console.ReadLine();
        //int opcion = int.Parse(Console.ReadLine());


        #region Condicionales else if
        //    Console.WriteLine("Ingresa un dia de L - V");
        //    string dia = Console.ReadLine();

        //    if (dia == "Lunes" || dia == "lunes")
        //    {
        //        Console.WriteLine("Seleccionaste el dia Lunes");
        //    }
        //    else if (dia == "Martes")
        //    {
        //        Console.WriteLine("Seleccionaste el dia Martes");
        //    }
        //    else if (dia == "Miercoles")
        //    {
        //        Console.WriteLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("No tengo esas opciones");
        //    }

        //}
        #endregion

        #region CONDICION SWITCH

        //switch (opcion)
        //{
        //    case "A":
        //        Console.WriteLine("Dia lunes");
        //        break;

        //    case "B":
        //        Console.WriteLine("Dia martes");
        //        break;

        //        case "C":
        //            Console.WriteLine("Dia miercoles");
        //        break;

        //    default:
        //        Console.WriteLine("No tengo ninguna de las opciones");
        //        break;


        //}
        #endregion
    }
}

