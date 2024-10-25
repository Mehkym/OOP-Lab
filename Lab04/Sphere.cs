using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Sphere : Сircle
    {
        public double Z {  get; set; }
        public double SquareFootage()
        {
            return 4 * Math.PI * Math.Pow(R, 2);

        }

        public new void Print()
        {
            Console.WriteLine($"Сфера з центром ({this.X};{this.Y};{this.Z}) та радіусом {this.R} ");
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
//	Визначити довжину кола та площу поверхні сфери