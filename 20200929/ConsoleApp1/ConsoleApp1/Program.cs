using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            

           List<int> numeros = new List<int> {1, 2, 3, 6, 9, 25};

           

           var pares = numeros.Where(numero => numero%2 == 0);

           

        }
    } 
}
