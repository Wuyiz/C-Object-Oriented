/*
   　　　┏┓　　　┏┓
   　　┏┛┻━━━┛┻┓
   　　┃　　　　　　　 ┃
   　　┃　　　━　　　 ┃
   　　┃　┳┛　┗┳　┃
   　　┃　　　　　　　 ┃
   　　┃　　　┻　　　 ┃
   　　┃　　　　　　　 ┃
   　　┗━┓　　　┏━┛Codes are far away from bugs with the animal protecting
   　　　　┃　　　┃    神兽保佑,代码无bug
   　　　　┃　　　┃
   　　　　┃　　　┗━━━┓
   　　　　┃　　　　　 ┣┓
   　　　　┃　　　　 ┏┛
   　　　　┗┓┓┏━┳┓┏┛
   　　　　　┃┫┫　┃┫┫
   　　　　　┗┻┛　┗┻┛
*/
using System;
using System.Windows.Forms;
using Library6335;

namespace Win6335.OOP6335 {
    public partial class ComplexForm6335 : Form {
        ComplexNumber6335 complex = new ComplexNumber6335();    //实例化复数类对象
        ComplexNumber6335 complexNumber1;
        ComplexNumber6335 complexNumber2;
        bool isException;

        private double real_figure_1 { get; set; }  //存放1號实数
        private double unreal_figure_1 { get; set; }  //存放1號虚数
        private double real_figure_2 { get; set; }  //存放2號实数
        private double unreal_figure_2 { get; set; }  //存放2號虚数

        public ComplexForm6335() {
            InitializeComponent();
        }

        //验证输入规范性，同时获取textbox内容
        public void isValid() {

            try {
                isException = true;
                if (tabControl1.SelectedIndex == 0) {
                    real_figure_1 = Convert.ToDouble(tbRfigure1.Text.Replace(" ", string.Empty));    //获取复数1
                    unreal_figure_1 = Convert.ToDouble(tbURfigure1.Text.Replace(" ", string.Empty));

                    real_figure_2 = Convert.ToDouble(tbRfigure2.Text.Replace(" ", string.Empty));    //获取复数2
                    unreal_figure_2 = Convert.ToDouble(tbURfigure2.Text.Replace(" ", string.Empty));

                    complexNumber1 = new ComplexNumber6335(real_figure_1, unreal_figure_1);
                    complexNumber2 = new ComplexNumber6335(real_figure_2, unreal_figure_2);
                } else {
                    complexNumber1 = ComplexNumber6335.Parse(tbcomplex1.Text);
                    complexNumber2 = ComplexNumber6335.Parse(tbcomplex2.Text);

                }

            } catch (Exception) {
                MessageBox.Show("Bug千万条，报错第一条。编程不规范，头发两行泪。",
                    "北京第三区交通委提醒您");
                isException = false;
            }
        }

        //Addition event
        private void rbAdd_Click(object sender, EventArgs e) {
            isValid();  //验证
            if (isException) {
                complex = complexNumber1 + complexNumber2;  //调用重载后的 + 运算
                tbResult.Text = $"加法运算：{complexNumber1.ToString()}+" +
                    $"{(complexNumber2.A < 0 ? "(" + complexNumber2.ToString() + ")" : complexNumber2.ToString())}" +
                    $"={complex.ToString()}";   //中间的三目运算表达式表示当第二个复数的实部为负时，加括号
            }
        }

        //Subtraction event
        private void rbSub_Click(object sender, EventArgs e) {
            isValid();  //验证
            if (isException) {
                complex = complexNumber1 - complexNumber2;  //调用重载后的 - 运算
                tbResult.Text = $"减法运算：{complexNumber1.ToString()}-({complexNumber2.ToString()})" +
                    $"={complex.ToString()}";
            }
        }

        //Comparison operation event: Equal
        private void rbEq_Click(object sender, EventArgs e) {
            isValid();  //验证
            if (isException) {
                bool result = complexNumber1 == complexNumber2;  //调用重载后的 Eq 运算
                tbResult.Text = $"比较运算：{complexNumber1.ToString()}=={complexNumber2.ToString()}" +
                    $" is {result}";
            }
        }

        //Comparison operation event: Not Equal
        private void rbNeq_Click(object sender, EventArgs e) {
            isValid();  //验证
            if (isException) {
                bool result = complexNumber1 != complexNumber2;  //调用重载后的 Neq 运算
                tbResult.Text = $"比较运算：{complexNumber1.ToString()}!={complexNumber2.ToString()}" +
                    $" is {result}";
            }
        }

        //Comparison operation event: Less than
        private void rbLt_Click(object sender, EventArgs e) {
            isValid();  //验证
            if (isException) {
                bool result = complexNumber1 < complexNumber2;  //调用重载后的 &lt 运算
                tbResult.Text = $"比较运算：{complexNumber1.ToString()}<{complexNumber2.ToString()}" +
                    $" is {result}";
            }
        }

        //Comparison operation event: Greater than
        private void rbGt_Click(object sender, EventArgs e) {
            isValid();  //验证
            if (isException) {
                bool result = complexNumber1 > complexNumber2;  //调用重载后的 &gt 运算
                tbResult.Text = $"比较运算：{complexNumber1.ToString()}>{complexNumber2.ToString()}" +
                    $" is {result}";
            }
        }
    }
}
