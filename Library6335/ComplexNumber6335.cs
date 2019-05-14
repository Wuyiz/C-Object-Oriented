/*
                   _ooOoo_
                  o8888888o
                  88" . "88
                  (| -_- |)
                  O\  =  /O
               ____/`---'\____
             .'  \\|     |//  `.
            /  \\|||  :  |||//  \
           /  _||||| -:- |||||-  \
           |   | \\\  -  /// |   |
           | \_|  ''\---/''  |   |
           \  .-\__  `-`  ___/-. /
         ___`. .'  /--.--\  `. . __
      ."" '<  `.___\_<|>_/___.'  >'"".
     | | :  `- \`.;`\ _ /`;.`/ - ` : | |
     \  \ `-.   \_ __\ /__ _/   .-` /  /
======`-.____`-.___\_____/___.-`____.-'======
                   `=---='
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            佛祖保佑       永无BUG
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library6335 {
    public class ComplexNumber6335 {
        public ComplexNumber6335() {
        }

        public ComplexNumber6335(double a, double b) {
            //初始化实部和虚部字段
            A = a;
            B = b;
        }

        public double A { get; set; } //定义实数

        public double B { get; set; } //定义虚数

        //重载运算符：+
        public static ComplexNumber6335 operator +(ComplexNumber6335 c1, ComplexNumber6335 c2) {
            ComplexNumber6335 c3 = new ComplexNumber6335 {
                A = c1.A + c2.A,
                B = c1.B + c2.B
            };
            return c3;
        }

        //重载运算符：-
        public static ComplexNumber6335 operator -(ComplexNumber6335 c1, ComplexNumber6335 c2) {
            ComplexNumber6335 c3 = new ComplexNumber6335 {
                A = c1.A - c2.A,
                B = c1.B - c2.B
            };
            return c3;
        }

        //重载比较运算符：!=
        public static bool operator !=(ComplexNumber6335 c1, ComplexNumber6335 c2) {
            bool state = false;

            //判断c1对象是否存在
            if ((c1 as object) != null) {
                /*
                 * 调用重载的Equals方法
                 * return 若相等，返回false
                 */
                state = !c1.Equals(c2); //调用重载的Equals方法 若相等，返回false
            }

            return state;
        }

        //重载比较运算符：==
        public static bool operator ==(ComplexNumber6335 c1, ComplexNumber6335 c2) {
            bool state = false;

            //判断c1对象是否存在
            if ((c1 as object) != null) {
                /*
                 * 调用重载的Equals方法
                 * return 若相等，返回false
                 */
                state = c1.Equals(c2);  //调用重载的Equals方法
            }

            return state;
        }

        //重载比较运算符：&lt
        public static bool operator <(ComplexNumber6335 c1, ComplexNumber6335 c2) {
            bool state = false;
            double a = Math.Sqrt(Math.Pow(c1.A, 2) + Math.Pow(c1.B, 2));    //取模
            double b = Math.Sqrt(Math.Pow(c2.A, 2) + Math.Pow(c2.B, 2));    //取模

            if (a < b) {
                state = true;
            }

            return state;
        }

        //重载比较运算符：&gt
        public static bool operator >(ComplexNumber6335 c1, ComplexNumber6335 c2) {
            bool state = false;
            double a = Math.Sqrt(Math.Pow(c1.A, 2) + Math.Pow(c1.B, 2));    //取模
            double b = Math.Sqrt(Math.Pow(c2.A, 2) + Math.Pow(c2.B, 2));    //取模

            if (a > b) {
                state = true;
            }

            return state;
        }

        //重载比较运算符：<=
        public static bool operator <=(ComplexNumber6335 c1, ComplexNumber6335 c2) {
            bool state = false;
            double a = Math.Sqrt(Math.Pow(c1.A, 2) + Math.Pow(c1.B, 2));    //取模
            double b = Math.Sqrt(Math.Pow(c2.A, 2) + Math.Pow(c2.B, 2));    //取模

            if (a <= b) {
                state = true;
            }

            return state;
        }

        //重载比较运算符：>=
        public static bool operator >=(ComplexNumber6335 c1, ComplexNumber6335 c2) {
            bool state = false;
            double a = Math.Sqrt(Math.Pow(c1.A, 2) + Math.Pow(c1.B, 2));    //取模
            double b = Math.Sqrt(Math.Pow(c2.A, 2) + Math.Pow(c2.B, 2));    //取模
            if (a >= b) {
                state = true;
            }

            return state;
        }

        /// <summary>
        /// 解析思路
        ///  1、先解析到复数虚部，如果没有虚部则匹配失败
        ///  2、将源字符串中的虚部剔除
        ///  3、根据实际匹配情况进行赋值
        /// </summary>
        /// <param name="input">value</param>
        /// <returns>ComplexNumber6335</returns>
        public static ComplexNumber6335 Parse(string input) {
            input = input.Replace(" ", string.Empty);
            ComplexNumber6335 complex = new ComplexNumber6335();

            /* 正则匹配规则
             *  (?<=(\-|\+?)\d*\.?\d*) 零宽度正回顾后发断言：确保匹配目标前方是实部，但不匹配实部
             *  (\-|\+?)\d*\.?\d*i  匹配虚部字符串
             *  (?!(\-|\+)\d)   零宽度负预测先行断言：确保匹配目标后方没有其他数字
             */
            Regex rex_real = new Regex(@"(?<=(\-|\+?)\d*\.?\d*)(\-|\+?)\d*\.?\d*i(?!(\-|\+)\d)");

            try {
                Match m1 = rex_real.Match(input);

                input = m1.Success ? input.Replace(m1.Value, string.Empty) : input;

                if (m1.Value.Contains("i")) {
                    if (input != string.Empty) {
                        complex.A = Convert.ToDouble(input);
                    } else {
                        complex.A = 0.0;
                    }
                } else {
                    throw new FormatException();
                }

                /* 判断
                 *  1、如果匹配到了虚部
                 *  2、虚部不为0
                 * 否则
                 *  抛异常
                 */
                if (m1.Success && !Regex.IsMatch(m1.Value, @"(?<=(\-|\+?))[0]+\.[0]+|[0]+|\.[0](?=i)")) {
                    if (Regex.IsMatch(m1.Value, @"\-i")) {
                        complex.B = -1.0;
                    } else if (Regex.IsMatch(m1.Value, @"^\+?i")) {
                        complex.B = 1.0;
                    } else {
                        complex.B = Convert.ToDouble(m1.Value.Replace("i", ""));
                    }
                } else {
                    throw new FormatException();
                }
            } catch (FormatException) {
                throw new FormatException();
            }

            return complex;
        }

        //重写Equal()
        public override bool Equals(object obj) {
            if (obj == null) {
                return false;
            }

            if (obj is ComplexNumber6335) {
                ComplexNumber6335 complexNumber = (ComplexNumber6335)obj;
                return complexNumber.A == A && complexNumber.B == B;
            }

            return false;
        }

        //重写Tostring()
        public override string ToString() {
            string a;
            string b;

            //string old_expression = "";

            /*
             * 实部格式化
             * A=0 输出 ""
             */
            if (A >= 0) {
                a = $"{(A == 0 ? "" : $"{A}")}";
            } else {
                a = $"{A}";
            }

            /*
             * 虚部格式化
             * B=0  输出 ""
             * B>=1 输出 "+Bi" 或者 "+i"
             */
            if (B >= 0) {
                b = $"{(B == 0 ? "" : $"{(A == 0 ? "" : "+")}{(B == 1 ? "" : $"{B}")}i")}";
            } else {
                b = $"{(B == -1 ? "-" : $"{B}")}i";
            }

            //如果实部和虚部值都为0，则输出0
            if (a == string.Empty && b == string.Empty) {
                b = "0";
            }

            return $"{a}{b}";
        }
    }
}