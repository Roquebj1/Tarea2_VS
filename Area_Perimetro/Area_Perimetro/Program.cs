using System;

namespace Area_Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double apotema, area, longitud_lado, num_lado, perimetro;
            Console.WriteLine("Ingrese el valor del apotema:");
            apotema = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del lado:");
            longitud_lado  = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del lado:");
            num_lado = double.Parse(Console.ReadLine());
            perimetro = num_lado * longitud_lado;
            area = apotema * apotema * num_lado * Math.Tan(Math.PI / num_lado);
            Console.WriteLine("El Valor del área es" + area);
            Console.WriteLine("El valor del perímetroes:" + perimetro);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey();

        }
    }
}
