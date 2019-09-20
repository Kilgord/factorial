using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            ulong num = ulong.Parse(Console.ReadLine());
            ulong factorial = 1;
            for (ulong i = 1; i <= num; i++)
            {
                factorial *= i;
                if (i == num)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write("{0} * ", i);
                }
            }
            Console.WriteLine(" = {0}", factorial);
           

            
            
            ulong s = 0;
            while (factorial != 0)
            {
                s = s + factorial % 10;
                factorial = factorial / 10;
            }
            Console.WriteLine("Сумма чисел равна: {0}", s);
            Console.ReadKey();
        }
    }
}
