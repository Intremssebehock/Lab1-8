using System;

namespace Lab1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double y = Convert.ToDouble((((3 * x - 5) * x + 2) * x - 1) * x + 7);
            Console.WriteLine("Ответ: "+ y);

            
            
        }
    }
}
