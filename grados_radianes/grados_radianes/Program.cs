using System;

namespace grados_radianes
{
    class Program
    {
        static void Main(string[] args)
        {
            double result, num1, num2;
            Console.WriteLine("Grados a Radianes:");
            Console.WriteLine("Radianes a Grados");
            num1 = float.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    {
                        Console.Write("Ingrese la la cantidad de la operación a converir");
                        num2 = float.Parse(Console.ReadLine());
                        result = num2 * 3.1416 / 180;
                        Console.WriteLine("El resultado es:" + result);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Ingrese la la cantidad de la operación a converir");
                        num2 = float.Parse(Console.ReadLine());
                        result = num2 * 180 / 3-1416;
                        Console.WriteLine("El resultado es:" + result);
                        break;
                    }

                        
                        
            }
        }
    }
}
