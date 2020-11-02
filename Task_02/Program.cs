/*
 * 2) Написать метод, преобразующий число переданное в качестве параметра в число, 
 * записанное теми же цифрами, но идущими в обратном порядке. 
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1024 
 * -------test_2-------
 * 120
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4201
 * -------test_2-------
 * 21
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(x));
        }

        static int ReverseNumber(int number)
        {
            var revNumber = 0;
            int count = number.ToString().Length - 1;
            while (number > 0)
            {
                revNumber += (number % 10) * (int)Math.Pow(10, count--);
                number /= 10;
            }
            return revNumber;
        }
    }
}
