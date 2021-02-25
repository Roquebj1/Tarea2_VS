using System;

namespace Serie_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, x = 0, y = 1, z = 1, i;
            Console.WriteLine("Ingrese el número");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < num; i++) ;
            {
                z = x + y;
                Console.WriteLine(z + "");
                x = y;
                y = z;
            }
        }
    }
}
