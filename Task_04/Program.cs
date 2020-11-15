/*
 * 4) Написать метод, вычисляющий значение функции G=F(X,Y) 
 * 𝐺 = 𝑋+sin⁡(𝑌),𝑋<𝑌 и 𝑋>0
 * 𝐺 = 𝑌−cos⁡(𝑋),𝑋>𝑌 и 𝑋<0
 * 𝐺 = 0.5∙𝑋∙𝑌, в остальных случаях
 * (аргументы sin и cos в радианах)
 * 
 * Ответ вывести с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * -2
 * -3
 * -------test_2-------
 * -1,5
 * 2
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * -5,58
 * -------test_2-------
 * -1,50
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04 {
	class Program {
		static void Main(string[] args) {
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
            double x;
            x = double.Parse(Console.ReadLine());
            double y;
            y = double.Parse(Console.ReadLine());
            Console.WriteLine($"{x} {y}");
            Console.WriteLine(G(x, y).ToString("F2", CultureInfo.GetCultureInfo("ru-RU")));
            Console.ReadLine();
		}
        public static double G(double x, double y) 
        {
            double eps = 0.00001;
            if ((y - x > eps) && (x > eps))
            {
                return x + Math.Sin(y);
            }
            else if ((x - y > eps) && (x < eps))
            {
                return y - Math.Cos(x);
            }
            else
            {
                return 0.5 * x * y;
            }
        }
	}
}
