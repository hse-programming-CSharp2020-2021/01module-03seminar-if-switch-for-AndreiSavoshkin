/*
 * 3) Написать метод, вычисляющий логическое значение функции G=F(X,Y).
 * Результат равен true, если точка с координатами (X,Y) попадает в фигуру G, 
 * и результат равен false, если точка с координатами (X,Y) не попадает в фигуру 
 * G. Фигура G - сектор круга радиусом R=2 c центром в точке 0 в диапазоне углов -90<= fi <=45.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 2
 * 0
 * -------test_2-------
 * 1
 * 2
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * True 
 * -------test_2-------
 * False
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
            double x;
            x = double.Parse(Console.ReadLine());
            double y;
            y = double.Parse(Console.ReadLine());
            Console.WriteLine(G(x, y));
        }
        public static bool G(double x, double y)
        {
            double R = 2;
            double p = Math.Sqrt(x * x + y * y);
            double cosq = x / p;
            bool angle = cosq >= 0 ? (cosq >= 1 / Math.Sqrt(2)) : (cosq > 0);
            return (p <= R) && (cosq >= 0) && angle;
        }
    }
}
