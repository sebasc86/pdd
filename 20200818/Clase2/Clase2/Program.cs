using System;
using System.Data.Common;
using System.Reflection;
using System.Reflection.Metadata;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world!");
            //F9 hago break point
            //Ingresar valor y capturar en consola 
            //string valor = Console.ReadLine();

            //int dado = int.Parse(valor);
            //string mensaje;

            //if (dado == 1)
            //{
            //    mensaje = "te ganaste un auto";

            //} else if (dado == 3 || dado == 5) { 

            //   mensaje = "te ganaste una moto";

            //} else {
            //    mensaje = "perdiste";
            //}

            //mensaje = dado == 1 ? "te ganaste un auto" : dado == 3 ? "te ganaste una moto" : "Segui participando";

            /*
                Console.Write no hace el salto de linea / Utilizado para concatenar caracteres.
                Console.Write("Tu dado Fue" + valor +  "te ganaste una"  + premio)
                Console.Write($"Tu dado Fue {valor} y te ganaste una  {premio}")
            */

            Console.WriteLine("Ingrese Su edad");
            string valor = Console.ReadLine();
            int age = int.Parse(valor);

            string mensaje;

            if(age >= 18)
            {
                mensaje = "Puede comprar bebidas alcoholicas";
            }else
            {
                mensaje = "Busque a un mayor para comprarlas.";
            }


            Console.WriteLine(mensaje);
            Console.ReadLine();

            for (int i = 0; i < length; i++)
            {

            }
        }
    }
}
