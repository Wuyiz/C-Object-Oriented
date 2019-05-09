using System;
using System.Windows.Forms;
using Library6335;

namespace Win6335.OOP6335 {
    public partial class ComplexForm6335 : Form {
        private double real_figure_1 { get; set; }  //存放1號实数
        private double unreal_figure_1 { get; set; }  //存放1號虚数
        private double real_figure_2 { get; set; }  //存放2號实数
        private double unreal_figure_2 { get; set; }  //存放2號虚数

        public ComplexForm6335() {
            InitializeComponent();
        }

        //验证输入规范性，同时获取textbox内容
        public void isValid(string a1, string b1, string a2, string b2) {
            a1 = a1.Replace(" ", "");
            b1 = b1.Replace(" ", "");
            a2 = a2.Replace(" ", "");
            b2 = b2.Replace(" ", "");

            try {
                real_figure_1 = Convert.ToDouble(a1);    //获取复数1
                unreal_figure_1 = Convert.ToDouble(b1);

                real_figure_2 = Convert.ToDouble(a2);    //获取复数2
                unreal_figure_2 = Convert.ToDouble(b2);

            } catch (Exception) {
                MessageBox.Show("Bug千万条，报错第一条。编程不规范，头发两行泪。",
                    "北京第三区交通委提醒您");
            }
        }

        ComplexNumber6335 complex = new ComplexNumber6335();    //实例化复数类对象

        //Addition event
        private void rbAdd_Click(object sender, EventArgs e) {
            isValid(tbRfigure1.Text, tbURfigure1.Text, 
                tbRfigure2.Text, tbURfigure2.Text);  //验证
            ComplexNumber6335 complexNumber1 = new ComplexNumber6335(real_figure_1, unreal_figure_1);
            ComplexNumber6335 complexNumber2 = new ComplexNumber6335(real_figure_2, unreal_figure_2);

            complex = complexNumber1 + complexNumber2;  //调用重载后的 + 运算
            tbResult.Text = $"加法运算：{complexNumber1.ToString()}+" +
                $"{(complexNumber2.A < 0 ? "(" + complexNumber2.ToString() + ")" : complexNumber2.ToString())}" +
                $"={complex.ToString()}";   //中间的三目运算表达式表示当第二个复数的实部为负时，加括号
        }

        //Subtraction event
        private void rbSub_Click(object sender, EventArgs e) {
            isValid(tbRfigure1.Text, tbURfigure1.Text,
                tbRfigure2.Text, tbURfigure2.Text); //验证
            ComplexNumber6335 complexNumber1 = new ComplexNumber6335(real_figure_1, unreal_figure_1);
            ComplexNumber6335 complexNumber2 = new ComplexNumber6335(real_figure_2, unreal_figure_2);

            complex = complexNumber1 - complexNumber2;  //调用重载后的 - 运算
            tbResult.Text = $"减法运算：{complexNumber1.ToString()}-({complexNumber2.ToString()})" +
                $"={complex.ToString()}";
        }

        //Comparison operation event: Equal
        private void rbEq_Click(object sender, EventArgs e) {
            isValid(tbRfigure1.Text, tbURfigure1.Text,
                tbRfigure2.Text, tbURfigure2.Text); //验证
            ComplexNumber6335 complexNumber1 = new ComplexNumber6335(real_figure_1, unreal_figure_1);
            ComplexNumber6335 complexNumber2 = new ComplexNumber6335(real_figure_2, unreal_figure_2);

            bool result = complexNumber1 == complexNumber2;  //调用重载后的 Eq 运算
            tbResult.Text = $"比较运算：{complexNumber1.ToString()}=={complexNumber2.ToString()}" +
                $"=is {result}";
        }

        //Comparison operation event: Not Equal
        private void rbNeq_Click(object sender, EventArgs e) {
            isValid(tbRfigure1.Text, tbURfigure1.Text,
                tbRfigure2.Text, tbURfigure2.Text); //验证
            ComplexNumber6335 complexNumber1 = new ComplexNumber6335(real_figure_1, unreal_figure_1);
            ComplexNumber6335 complexNumber2 = new ComplexNumber6335(real_figure_2, unreal_figure_2);

            bool result = complexNumber1 != complexNumber2;  //调用重载后的 Neq 运算
            tbResult.Text = $"比较运算：{complexNumber1.ToString()}!={complexNumber2.ToString()}" +
                $"=is {result}";
        }

        //Comparison operation event: Less than
        private void rbLt_Click(object sender, EventArgs e) {
            isValid(tbRfigure1.Text, tbURfigure1.Text,
                tbRfigure2.Text, tbURfigure2.Text); //验证
            ComplexNumber6335 complexNumber1 = new ComplexNumber6335(real_figure_1, unreal_figure_1);
            ComplexNumber6335 complexNumber2 = new ComplexNumber6335(real_figure_2, unreal_figure_2);

            bool result = complexNumber1 < complexNumber2;  //调用重载后的 &lt 运算
            tbResult.Text = $"比较运算：{complexNumber1.ToString()}<{complexNumber2.ToString()}" +
                $"=is {result}";
        }

        //Comparison operation event: Greater than
        private void rbGt_Click(object sender, EventArgs e) {
            isValid(tbRfigure1.Text, tbURfigure1.Text,
                tbRfigure2.Text, tbURfigure2.Text); //验证
            ComplexNumber6335 complexNumber1 = new ComplexNumber6335(real_figure_1, unreal_figure_1);
            ComplexNumber6335 complexNumber2 = new ComplexNumber6335(real_figure_2, unreal_figure_2);

            bool result = complexNumber1 > complexNumber2;  //调用重载后的 &gt 运算
            tbResult.Text = $"比较运算：{complexNumber1.ToString()}>{complexNumber2.ToString()}" +
                $"=is {result}";
        }
    }
}
