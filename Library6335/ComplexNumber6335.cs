using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
