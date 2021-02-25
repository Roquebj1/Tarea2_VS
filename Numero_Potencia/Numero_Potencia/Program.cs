using System;

namespace Numero_Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double baase, exponente, potencia;
            Console.WriteLine("Ingrese el valor de la base:");
            baase = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del exponente:");
            exponente = double.Parse(Console.ReadLine());
            potencia = Math.Pow(baase, exponente);
            Console.WriteLine("El valor de la potencia es:" + potencia);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey();
        }
    }
}
