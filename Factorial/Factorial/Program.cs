using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            long factorial = 1;
            Console.WriteLine("Ingrese un número");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + num + "!=1");
            for (i = 2; i <= num; i++) ;
            {
                factorial *= i;
                Console.WriteLine("\u00D7" + i);
            }
            Console.WriteLine("=" + factorial);
            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
