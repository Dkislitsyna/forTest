using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammING
{
    public class Program
    {
        public static int SumD(int num)  // сумма всех цифр в числе
        {
            int sm = 0;
            while (num > 0)
            {
                sm += num % 10;
                num /= 10;
            }
            return sm;
        }

        public static int CountD(int num) // количество цифр в числе
        {
            int count = 0;
            while (num > 0)
            {
                count += 1;
                num /= 10;
            }
            return count;
        }

        public static int MaxD(int num) //максимальная цифра
        {
            int mx = -1;
            while (num > 0)
            {
                if (num % 10 > mx) { mx = num % 10; }               
                num /= 10;
            }
            return mx;
        }

        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Сумма всех чисел введенного числа: " + SumD(number));
            Console.WriteLine("Количество цифр в введенном числе: " + CountD(number));
            Console.WriteLine("Максимальная цифра введенного числа: " + MaxD(number));
            Console.ReadKey();
        }
    }
}
