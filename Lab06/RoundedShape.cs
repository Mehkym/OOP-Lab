using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal abstract class RoundedShape
    {
        public double X { get; set; }
        public double Y { get; set; }

        private double r;

        public RoundedShape(double x, double y, double r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
        }

         ~ RoundedShape()
        {
            Console.WriteLine($"Спрацював деструктор (фіналізатор) класу RoundedShape");
        }

        public abstract void Print();
        public abstract void Input();

        public abstract double Length();

        public double R
        {
            get { return r; }

            set
            {
                if (value >= 0)
                {
                    r = value;
                }
            }
        }
    }
}
