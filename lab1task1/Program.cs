using System;
using System.Drawing;
using System.Runtime.Serialization.Json;

namespace lab1task1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість кутів: ");
            int n = int.Parse(Console.ReadLine());

            //масив з коордитанами
            double[] points = new double[n * 2];

            //вводимо координати
            for (int i = 0; i < n * 2; i += 2)
            {
                Console.WriteLine($"Введіть {i / 2 + 1}-i координати через пробіл:");
                double[] ps = Console.ReadLine().Split(' ').Select(x => Double.Parse(x)).ToArray();
                points[i] = ps[0];
                points[i + 1] = ps[1];
            }
            Polygon pol = new Polygon(points, n);

            //шукаємо сторони
            for (int i = 0; i < n; i++)
            {
                pol[i] = pol.ConvertToSide(points, i);
            }

            //виводимо сторони
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Сторона {i + 1} дорівнює {pol[i]}");
            }

            Console.WriteLine($"Периметр {pol.CalculatePerimeter()}");
            Console.WriteLine($"Площа {pol.CalculateSquare()}");
        }
    }
}