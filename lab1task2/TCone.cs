using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task2
{
    public class TCone : TCircle
    {
        private double height_;
        public TCone() : base()
        {
            height = 1;
        }
        public TCone(double height, double r) : base(r)
        {
            this.height = height;
        }
        public TCone(TCone copyTCone) : base(copyTCone)
        {
            this.height = copyTCone.height;
        }
        public double height
        {
            get { return height_; }
            set
            {
                if (value > 0)
                {
                    height_ = value;
                }
                else
                {
                    throw new ArgumentException("Висота не може бути менше рівно нуля");
                }
            }
        }
        public override string ToString()
        {
            return $"Конус з радіусом {this.r} та висотою - {this.height} ";
        }
        public new double Square()
        {
            return base.Square() + this.SquareSec();
        }
        public double SquareSec()
        {
            return Math.PI * this.r *
                (Math.Sqrt(Math.Pow(this.r, 2) + Math.Pow(this.height, 2)));
        }

        public double Volume()
        {
            return  (Math.PI * this.r * this.r * height)/3;
        }
        public bool IsEqual(TCone otherCone)
        {
            if (otherCone == null)
                return false;
            return this.height == otherCone.height && this.r == otherCone.r;
        }
        public static TCone operator +(TCone cone, TCone otherCone)
        {
            double new_h = cone.height + otherCone.height;
            double new_r = cone.r + otherCone.r;
            return new TCone(new_h, new_r);
        }
        public static TCone operator -(TCone cone, TCone otherCone)
        {
            double new_h = Math.Abs(cone.height - otherCone.height);
            double new_r = Math.Abs(cone.r - otherCone.r);
            return new TCone(new_h, new_r);
        }
        public static TCone operator *(TCone cone, double num)
        {
            double new_h = cone.height * num;
            double new_r = cone.r * num;
            return new TCone(new_h, new_r);
        }
        public static TCone operator *(double num, TCone cone)
        {
            double new_h = cone.height * num;
            double new_r = cone.r * num;
            return new TCone(new_h, new_r);
        }
    }
}
