using System;

namespace ChicoMayor_ChicoJoven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, mayor = 0, menor = 0;
            Console.WriteLine("Ingrese la cantidad de edades:");
            num = Convert.ToInt32(Console.ReadLine());
            int[] edades = new int[num + 1];
            for (i = 1; i <= num; i++)
            {
                Console.WriteLine("Por favor ingrese la edad de la persona:");
                edades[i] = Convert.ToInt32(Console.ReadLine());
            }
            mayor = edades[1];
            menor = edades[1];
            for (i = 1; i <= num; i++) ;
            {
                if (edades[i] > mayor)
                {
                    mayor = edades[i];
                }
                
                    else if (edades [i] < menor)
                    {
                        menor = edades[i];
                    }
                }
            Console.WriteLine("La edad de la persona mayor es:"+mayor);
            Console.WriteLine("La edad de la persona joven es:" + menor);
            }

        }
    }
}
