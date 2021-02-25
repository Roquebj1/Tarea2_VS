using System;

namespace _1_par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
int num= 0;
            Console.WriteLine("Ingrese un número:")
                num = int.Parse(Console.ReadLine());
            if ((num%2)==0)
            {
                Console.WriteLine("El Número ingresado es par");
            }
            else
            {
                Console.WriteLine("El Número ingresado es impar");
            }
        }
    }
}
