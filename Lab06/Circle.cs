using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Circle
        : RoundedShape
    {
        public Circle(double x = 0, double y = 0, double r = 0) : base(x, y, r) { }

        public override void Print()
        {
            Console.WriteLine($"Коло з центром ({this.X};{this.Y}) та радіусом {this.R}. Довжина кола = {Length():f2}");
        }


        public override void Input()
        {
            Console.WriteLine($"Коорденати центра кола = ");
            Console.Write("x = ");
            X = double.Parse(Console.ReadLine());

            Console.Write("y = ");
            Y = double.Parse(Console.ReadLine());

            Console.WriteLine($"Радіус кола = ");
            R = double.Parse(Console.ReadLine());
        }


        public override double Length()
        {
            return 2 * Math.PI * R;
        }

        ~Circle()
        {
            Console.WriteLine("Спрацював деструктор (фіналізатор) класу кола (Circle)");
        }
    }
}
