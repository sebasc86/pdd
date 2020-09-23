using System;
using System.Collections.Generic;
using System.Text;

namespace _20200908
{
    public class Calculadora
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }



    }
}
