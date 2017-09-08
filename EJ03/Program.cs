using System;

namespace EJ03
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberIN = "";
            int number = 0;
            while (!int.TryParse(numberIN, out number) || number < 0)
            {
                Console.Write("Ingrese numero: ");
                numberIN = Console.ReadLine();
            }
            int acum = 0;
            for (int i = 0; i < number; i++)
            {
                acum += i;
            }
            Console.Write("Resultado: " + acum.ToString());
            Console.Read();
        }
    }
}
