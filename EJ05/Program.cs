using System;
using System.Collections.Generic;

namespace EJ05
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberIN = "";
            int number = -1;
            List<int> numeros = new List<int>();
            while (number != 0)
            {
                Console.Write("Ingrese numeros, finalizar ingresando '0': ");
                numberIN = Console.ReadLine();
                if (int.TryParse(numberIN, out number))
                {
                    number = int.Parse(numberIN);
                    numeros.Add(number);
                }
            }
            Console.Write("El Promedio es: " + calcularPromedio(numeros));
            Console.Read();
        }

        private static string calcularPromedio(List<int> numeros)
        {
            int total = 0;
            foreach (int numero in numeros)
            {
                total += numero;
            }
            return ((double)total / numeros.Count).ToString();
        }
    }
}
