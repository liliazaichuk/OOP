using System;
using System.Drawing;
using System.Runtime.Serialization.Json;

namespace lab1task1
{

    class Polygon
    {
        public double[] points;
        private int _n;
        private double[] sides;
        public Polygon(double[] points, int n)
        {
            this.points = points;
            this.n = n;
            this.sides = new double[n];
        }
        public int n
        {
            get { return _n; }
            set
            {
                if (value > 2)
                {
                    _n = value;
                }
                else
                {
                    throw new ArgumentException("Многокутник повинен мати щонайменше 3 вершини");
                }
            }
        }
        public double this[int i]
        {
            get
            {
                if (i >= 0 && i < this.n)
                {
                    return sides[i];
                }
                else
                {
                    throw new IndexOutOfRangeException("Неправильний iндекс");
                }
            }
            set
            {
                if (i >= 0 && i < this.n)
                {
                    if (!(value <= 0))
                    {
                        sides[i] = value;
                    }
                    else
                    {
                        throw new ArgumentException("Значення не може бути меньше чи дорiвнювати 0");
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException("Неправильний iндекс");
                }
            }
        }
        public double ConvertToSide(double[] points, int i)
        {
            int x1Index = (i * 2) % points.Length;
            int y1Index = (i * 2 + 1) % points.Length;
            int x2Index = (i * 2 + 2) % points.Length;
            int y2Index = (i * 2 + 3) % points.Length;

            return Math.Sqrt(Math.Pow(points[x1Index] - points[x2Index], 2) + Math.Pow(points[y1Index] - points[y2Index], 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                perimeter += sides[i];
            }
            return perimeter;
        }
        public double CalculateSquare()
        {
            double square = 0;
            for (int i = 0; i < n * 2 - 1; i += 2)
            {
                int x1Index = i % points.Length;
                int y1Index = (i + 1) % points.Length;
                int x2Index = (i + 2) % points.Length;
                int y2Index = (i + 3) % points.Length;
                square += points[x1Index] * points[y2Index] - points[y1Index] * points[x2Index];
            }
            return Math.Abs(square / 2);
        }
    }
}

