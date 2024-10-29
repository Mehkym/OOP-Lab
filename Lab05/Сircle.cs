using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal class Сircle
    {
        public double X {  get; set; }
        public double Y { get; set; }

        private double r;

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

        public virtual double Length()
        { 
            return 2 * Math.PI * R; 
        }


        public virtual void Print()
        {
            Console.WriteLine($"Коло з центром ({this.X};{this.Y}) та радіусом {this.R}. Довжина кола = {Length()} ");
        }

        public virtual void Input()
        {
            Console.WriteLine("Введи коорденати центра кола = ");
            Console.Write("x = ");
            X = double.Parse(Console.ReadLine());

            Console.Write("y = ");
            Y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введи радіус кола = ");
            R = double.Parse(Console.ReadLine());

        }
    }
}




//  Створити клас „ коло  ” і створити відповідні методи:
//	задання координат(x_0, y_0) центру кола та його радіусу,
//	а також виведення цих даних на екран;
//  визначення довжини кола. 
//	Створити похідний клас „сфера  ” . Перевантажити   відповідні методи:
//	задання координат   центру сфери та її радіусу,
//	а також виведення цих даних на екран;
//  визначення площі поверхні сфери. 
//	Створити об’єкти класів „коло  ” та „сфера  ”.
//	Визначити довжину кола та площу поверхні сфери.



