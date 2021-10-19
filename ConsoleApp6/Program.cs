using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите 1, 2 или 3:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double u = 0, y;
                switch (n)
                {
                    case 1: u = Math.Sin(x); break;
                    case 2: u = Math.Cos(x); break;
                    case 3: u = Math.Tan(x); break;
                }
                if (u + x > -0.5) y = (Math.Pow(2 * u + 1, 2)) / 7 * Math.PI + x;
                else if (-0.5 <= u + x && u + x <= 10 / 10 / 10) y = Math.Pow(Math.Cos(u), 2) - Math.Sin(u / 3);
                else y = Math.Log10(u + x) - Math.Pow(Math.E, x);
                Console.WriteLine($"y={y:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

