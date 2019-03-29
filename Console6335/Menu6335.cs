using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6335 {
    class Menu6335 {
        String opt;
        public Menu6335() {
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.WriteLine("===================学号：姓名===================\n");
                Console.WriteLine("      1-----------【例1.4】一维数组");
                Console.WriteLine("      2-----------【例1.5】二维数组");
                Console.WriteLine("      3-----------【例1.6】控制台输入输出");
                Console.WriteLine("      4-----------【例1.8】判断闰年");
                Console.WriteLine("      0-----------退出\n");
                Console.WriteLine("================================================\n");
                Console.Write("请输入您的选择：");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        ArrayDemo6335.Array1_6335();
                        break;
                    case "2":
                        ArrayDemo6335.Array2_6335();
                        break;
                    case "3":
                        ParseDemo6335.Parse1_6335();
                        break;
                    case "4":
                        ParseDemo6335.Parse2_6335();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("选择错误！！");
                        break;
                }
                Console.WriteLine("请安任意键开始重新选择......");
                Console.ReadKey();
                Console.Clear();
            } while (true);
            Console.ResetColor();
            
        }
    }
}
