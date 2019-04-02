using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6335 {
    class Hotel {
        private static int rest;   //成员变量rest，表示剩余房间数 
        const string EMPTY = "空";


        /**
         * （1）如果当前客满，给予提示，结束
         * （2）输入姓名
         * （3）找到未入住的客房，登记姓名，并显示房号
         */
        public static void In6335(string[] rooms) {
            int count = 0;

            for (int i=0; i<rooms.Length; i++,count++)
            {
                if (rooms[i]==EMPTY)
                {
                    Console.Write("请登记住户姓名：");
                    rooms[i] = Console.ReadLine();
                    Console.WriteLine("以为您办理入住#{0},欢迎！\n请按回车键继续！",i+1);
                    Console.ReadLine();
                    break;
                } 
            }

            if (count == rest)
            {
                Console.WriteLine("当前客满，无法入住！\n请按回车键继续！");
                Console.ReadLine();
            }
        }

        /**
         * （1）输入房号
         * （2）如果房号正确，转（3），否则转（1）
         * （3）如果输入的房号是已入住状态，清空住户姓名
         *      否则，提示
         */
        public static void Out6335(string[] rooms) {
            int num;

            do
            {
                Console.Write("请输入退房号码：");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num<1 || num>15);

            if (rooms[num-1]!=EMPTY)
            {
                rooms[num-1] = EMPTY;
                Console.WriteLine("#{0}房间退房成功！\n请按回车键继续！",num);
                Console.ReadLine();
            } else
            {
                Console.WriteLine("#{0}房间无人入住，无法进行退房操作！\n请按回车键继续！", num);
                Console.ReadLine();
            }
            
        }

        /**
         * （1）初始化客房资源，即用常量初始化数组，将数组中所有元素设为EMPTY
         * （2）rest设为客房总数
         */
        public static void InitRooms6335(string[] rooms) {
            rest = 15;  //初始化客房总数

            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = EMPTY;
            }
        }

        /**
         * （1）显示当前入住情况，每行三个客房信息
         * （2）统计剩余客房数
         * （3）如果客满，显示今日客满，否则显示剩余客房数
         */
        public static void ShowRooms6335(string[] rooms) {
            int num = 1;
            int count = 0;
            foreach (var info in rooms)
            {
                Console.Write("#{0}: {1}\t\t\t", num, info);
                if (num%3==0)
                {
                    Console.WriteLine();
                }
                if (info!=EMPTY)
                {
                    count++;
                }
                num++;
            }
            if (count==rest)
            {
                Console.WriteLine("* * * * * * * 今日客满 * * * * * * *");
            } else
            {
                Console.WriteLine("* * * * * * * 余：{0} * * * * * * *",rest-count);
            }
        }

        /**
         * （1）显示当前入住情况（调用ShowRooms6335方法）
         * （2）显示0、1、2的菜单选项
         */
        public static void ShowMenu6335(string[] rooms) {
            Console.WriteLine("= = = = = = = = = 211606335：吴沂章，皇家帝国酒店v1.0 = = = = = = = = =");
            Console.WriteLine("当前入住情况");
            ShowRooms6335(rooms);
            Console.WriteLine("\t1.---------入住登记");
            Console.WriteLine("\t2.---------退房");
            Console.WriteLine("\t0.---------结束");
            Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");

        }

        /**
         * （1）显示菜单（调用ShowMenu6335方法）
         * （2）等待用户输入
         * （3）如果输入1或2，执行相应的功能（调用out6335或in6335方法），回到（1）
         *      如果输入0，结束程序
         *      否则，提示输入错误，回到（2）
         */
        public static void Menu6335(string[] rooms) {
            string opt;
            do
            {
                a: ShowMenu6335(rooms);
                s: Console.Write("请输入选择：");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        In6335(rooms);
                        goto a;
                    case "2":
                        Out6335(rooms);
                        goto a;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("输入错误");
                        goto s;
                }
                Console.ReadKey();

            } while (true);
        }

        /**
         * （1）初始化客房资源（调用InitRooms6335方法）
         * （2）进入菜单（调用Menu6335方法）
         */
        static void Main(string[] args) {
            string[] rooms=new string[15];

            Console.ForegroundColor = ConsoleColor.Green;
            InitRooms6335(rooms);
            Menu6335(rooms);
            Console.ResetColor();
        }
    }
}
