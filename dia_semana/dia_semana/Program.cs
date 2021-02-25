using System;

namespace dia_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia_semana;
            Console.Write("Ingrese el valor del día de la semana:");
            dia_semana = int.Parse(Console.ReadLine());
            if (dia_semana == 1)
                Console.WriteLine("Lunes");
            if (dia_semana == 2)
                Console.WriteLine("Martes");
            if (dia_semana == 3)
                Console.WriteLine("Miércoles");
            if (dia_semana == 4)
                Console.WriteLine("Jueves");
            if (dia_semana == 5)
                Console.WriteLine("viernes");
            if (dia_semana == 6)
                Console.WriteLine("Sábado");
            if (dia_semana == 7)
                Console.WriteLine("Domingo");
            if (dia_semana < 1 || dia_semana > 7)
                Console.WriteLine("Peeeep Error_Día No Válido");
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para terminar...");
            Console.ReadKey();
        }
    }
}
