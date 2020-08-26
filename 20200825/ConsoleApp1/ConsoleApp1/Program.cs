using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int intentos = 1;
            //string clave = "";

            //while (clave != "secreto" & intentos < 4)
            //{
            //    Console.WriteLine("ingrese la contraseña:");
            //    clave = Console.ReadLine();
            //    intentos++;
            //}

            int numero = 5;
            int clave;

            do
            {
                Console.WriteLine("Adivine un numero del 1 al 10");
                string valor = Console.ReadLine();
                clave = int.Parse(valor);

            } while (clave != numero);

           


        }
    }
}
