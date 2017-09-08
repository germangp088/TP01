using System;

namespace EJ04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = ingresarNumero("Ingrese numero 1: ");
            int numero2 = ingresarNumero("Ingrese numero 2: ");
            int comunDenominador = buscarComunDenominador(numero1, numero2);
            Console.Write("Maximo comun denominador: " + comunDenominador);
            Console.Read();
        }

        static int ingresarNumero(string mensaje)
        {
            string numberIN = "";
            int number = 0;
            while (!int.TryParse(numberIN, out number) || number < 0)
            {
                Console.Write(mensaje);
                numberIN = Console.ReadLine();
            }
            return number;
        }

        static int buscarComunDenominador(int numero1, int numero2)
        {
            int comunDenominador = 0;
            int length = numero1 > numero2 ? numero1 : numero2;
            for (int i = length; i >= 0; i--)
            {
                if (divisible(numero1, i) && divisible(numero2, i))
                {
                    comunDenominador = i;
                    break;
                }
            }
            return comunDenominador;
        }

        static bool divisible(int numero, int divisor)
        {
            return (numero % divisor == 0);
        }
    }
}
