using System;
using System.Collections.Generic;
using System.Text;

namespace _20200908
{
    public class CalculadoraCientifica : Calculadora
    {

        public int Potencia(int numero, int exponente)
        {
            return (int) Math.Pow(numero, exponente);
        }

    }
}
