using ClassLibrary1;
using System;

namespace _20200908
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Calculadora cal = new Calculadora();
            //Class1 clase = new Class1();

            Calculadora cal = new Calculadora();
            Console.WriteLine(cal.Restar(10, 8));
            Console.WriteLine(cal.Sumar(10, 8));
            Console.WriteLine(cal.Multiplicar(10, 8));
            Console.WriteLine(cal.Dividir(10, 8));

        }
    }
}
