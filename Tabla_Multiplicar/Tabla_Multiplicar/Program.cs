using System;

namespace Tabla_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num, resultado;
            Console.Write("Ingrese un número del 1 al 10");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= 10; i++)
            {
                resultado = i * num;
                Console.WriteLine(num + "\u00D7" + i + "=", resultado );
            }
            Console.WriteLine("Presione cualquier tecla para terminar");
            Console.ReadKey();
        }
    }
}
