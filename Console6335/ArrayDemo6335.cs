using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6335
{
    class ArrayDemo6335
    {
        public static void Array1_6335()
        {
            int max, min;
            int[] a = new int[10] { 78, 45, 34, 67, 91, 86, 52, 49, 62, 81 };
            max = min = a[0];
            for(int i = 1; i<10; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("最大数是{0},最小数是{1}", max, min);
            Console.ReadLine();
        }
        public static void Array2_6335()
        {
            int[,] a;
            a = new int[2,3];
            a[0, 0] = 1;
            a[0, 1] = 2;
            a[0, 2] = 3;
            a[1, 0] = 4;
            a[1, 1] = 5;
            a[1, 2] = 6;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
