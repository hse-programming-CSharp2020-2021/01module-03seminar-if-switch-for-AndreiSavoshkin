/* 
 * 1) Написать метод, находящий четырёхзначное десятичное число s, все цифры которого одинаковы 
 * и которое представляет собой сумму арифметической прогресии с шагом 1 и первым членом l,
 * то есть s = l + (l+1) + (l+2) + ...
 * Вывести полученное число.
 * Или сообщить о том, что такого числа нет.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 555
 * -------test_2-------
 * 300
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 1111
 * -------test_2-------
 * 0
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main()
        {
            int l;
            l = int.Parse(Console.ReadLine());
            int result = CalcS(l);
            if (result == -1)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        public static int CalcS(int l)
        {
            int res = -1;
            int element = l++;
            while (element < 10000)
            {
                element += l++;
                if (element % 100 == element / 100 && element / 1000 == element % 10)
                {
                    return element;
                }
            }
            return res;
        }


    }
}
