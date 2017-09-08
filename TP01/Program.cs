using System;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Nombre completo: " + nombre + " " + apellido);
            Console.Read();
        }
    }
}
