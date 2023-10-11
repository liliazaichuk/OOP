using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task2
{
    public class TCircle
    {
        protected double _r;
        public TCircle()
        {
            r = 1;
        }
        public TCircle(double r)
        {
            this.r = r;
        }
        public TCircle(TCircle copyTCircle)
        {
            this.r = copyTCircle.r;
        }
        public double r
        {
            get { return _r; }
            set
            {
                if (value > 0)
                {
                    _r = value;
                }
                else 
                { 
                    throw new ArgumentException("Радіус не може бути менше рівно нуля"); 
                } 
            }        }
        
        public override string ToString()
        {
            return $"Радіус кола {this.r}";
        }
        public double Square()
        {
            return Math.PI * this.r * this.r;
        }
        public double SquareSec(double angle)
        {
            return Square() * angle / 360;
        }
        public double CircleLength()
        {
            return 2*Math.PI* this.r;
        }
        public bool IsEqual(TCircle otherCircle)
        {
            if (otherCircle == null)
                return false;
            return this.r == otherCircle.r;
        }
        public static TCircle operator +(TCircle circle, TCircle otherCircle)
        {
            double new_r = circle.r + otherCircle.r;
            return new TCircle(new_r);
        }
        public static TCircle operator -(TCircle circle, TCircle otherCircle)
        {
            double new_r = Math.Abs(circle.r - otherCircle.r);
            return new TCircle(new_r);
        }
        public static TCircle operator *(TCircle circle, double num)
        {
            double new_r = circle.r * num;
            return new TCircle(new_r);
        }
        public static TCircle operator *(double num, TCircle circle)
        {
            double new_r = circle.r * num;
            return new TCircle(new_r);
        }
    }
}
