using System;

namespace EJ02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            string edadIN = "";
            int edad = 0;
            while (!int.TryParse(edadIN, out edad) || edad < 0)
            {
                Console.Write("Ingrese edad: ");
                edadIN = Console.ReadLine();
            }
            string resultado = "menor";
            if (edad > 18)
            {
                resultado = "mayor";
            }
            Console.Write(nombre + " es " + resultado + " de edad.");
            Console.Read();
        }
    }
}
