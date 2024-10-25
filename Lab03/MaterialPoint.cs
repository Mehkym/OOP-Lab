using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class MaterialPoint
    {

        private double x;       // Поле класу
        private double y;
        private double z;

        private double vx;
        private double vy;
        private double vz;

        // Конструктор з параметрами
        public MaterialPoint(double x = 0, double y = 0, double z = 0, double vx = 0, double vy = 0, double vz = 0)
        {
            this.x = x;  //SetX (х) //
            this.y = y;
            this.z = z;
            this.vx = vx;
            this.vy = vy;
            this.vz = vz;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public void SetZ(double z)
        {
            this.z = z;
        }
        public void SetVX(double vx)
        {
            this.vx = vx;
        }
        public void SetVY(double vy)
        {
            this.vy = vy;
        }
        public void SetVZ(double vz)
        {
            this.vz = vz;
        }
        public double GetX()
        {
            return this.x;
        }

        public double GetY()
        {
            return this.y;
        }

        public double GetZ()
        {
            return this.z;
        }

        public double GetVX()
        {
            return this.vx;
        }

        public double GetVY()
        {
            return this.vy;
        }
        public double GetVZ()
        {
            return this.vz;
        }

        public bool IsInFirstOctant(double t)
        {
            // x1, y1, z1 це координати точки після переміщення за час t
            double x1 = this.x + vx * t;
            double y1 = this.y + vy * t;
            double z1 = this.z + vz * t;
            if (x1 > 0 && y1 > 0 && z1 > 0)
            {
                return true;

            }
            return false;
        }

        public void Input()
        {
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = double.Parse(Console.ReadLine());
            Console.Write("z = ");
            z = double.Parse(Console.ReadLine());
            Console.Write("vx = ");
            vx = double.Parse(Console.ReadLine());
            Console.Write("vy = ");
            vy = double.Parse(Console.ReadLine());
            Console.Write("vz = ");
            vz = double.Parse(Console.ReadLine());

        }

        public void Print()
        {
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
            Console.WriteLine($"vx = {vx}, vy = {vy}, vz = {vz}");
        }

    }

}

//    Створити масив об’єктів класу „матеріальна точка”.
//    Кожна точка характеризується координатами початкового пололження
//    та вектором рівномірної швидкості.
//    Визначити номера точок,
//    які за введений користувачем час t попадають в перший октант.