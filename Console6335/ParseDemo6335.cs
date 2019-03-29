using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6335
{
    class ParseDemo6335
    {
        public static void Parse1_6335()
        {
            float kg, g, jin;
            Console.Write("请输入重量(kg): ");
            kg = float.Parse(Console.ReadLine());
            g = kg*1000;
            Console.WriteLine("{0}kg等于{1}g",kg,g);
            jin = g/500;
            Console.WriteLine("{0}kg等于{1}斤",kg,jin);
            Console.WriteLine("{0}kg等于{1}公斤", kg, kg);
            Console.ReadKey();
        }

        public static void Parse2_6335()
        {
            int Year;
            Console.Write("请输入年份: ");
            Year = Int32.Parse(Console.ReadLine());
            if (Year%4==0 && Year%100!=0 || Year%400==0)
            {
                Console.WriteLine("{0}年是闰年\n", Year);
            }
            else
            {
                Console.WriteLine("{0}年是平年\n",Year);
            }
            Console.ReadKey();
        }
    }
}
