using System;

namespace Numeros_Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2, i, contador = 0;
            while(num<=1000)
            {
                for (i = 1; i <= num; i++) ;
                {
                    contador++;
                }
            }
            {
                Console.WriteLine("El número sí es primo" + num);
            }
            contador = 0;
            num++;
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
