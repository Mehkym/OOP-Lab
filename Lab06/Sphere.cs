using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Sphere
        : RoundedShape
    {

        public Sphere(double x = 0, double y = 0, double z = 0, double r = 0) : base(x, y, r) 
        {
            Z = z;
        }
        public double Z { get; set; }

        public override double Length()
        {
            return 4 * Math.PI * Math.Pow(R, 2);

        }

        public override void Print()
        {
            Console.WriteLine($"Сфера з центром ({this.X};{this.Y};{this.Z}) та радіусом {this.R}. Площа поверхні сфери = {Length():f2} ");
        }

        public override void Input()
        {
            Console.WriteLine("Введи коорденати центра сфери = ");
            Console.Write("x = ");
            X = double.Parse(Console.ReadLine());

            Console.Write("y = ");
            Y = double.Parse(Console.ReadLine());

            Console.Write("z = ");
            Z = double.Parse(Console.ReadLine());

            Console.WriteLine("Введи радіус сфери = ");
            R = double.Parse(Console.ReadLine());

        }

        ~Sphere()
        {
            Console.WriteLine("Спрацював деструктор (фіналізатор) класу сфера (Sphere)");
        }
    }
}
