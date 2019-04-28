using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335.OOP6335 {
    public partial class BigNumForm6335 : Form {
        private string[] bits = { "分", "角", "元", "拾", "佰", "千", "万", "十万", "佰万", "仟万", "亿" };
        private string[] nums = { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };

        public Color Color {
            get {
                if (Money < Convert.ToDecimal(0)) {
                    return Color.Red;
                } else {
                    return Color.Blue;
                }
            }
        }
        public decimal Money { get; set; }

        public BigNumForm6335() {
            InitializeComponent();
            Money = Math.Round(Money, 2, MidpointRounding.AwayFromZero);    //四舍五入
        }

        public BigNumForm6335(decimal monyey) {
            InitializeComponent();  //初始化窗口控件
            Money = Math.Round(monyey, 2, MidpointRounding.AwayFromZero);   //四舍五入
            //string str = ToString();    //调式专用
        }

        private string getIntString(string intString) {
            StringBuilder stringBuilder = new StringBuilder(intString);

            int iTemp = stringBuilder.Length;  //获取整数部分位数
            intString = ""; //初始化string

            //当输入数字的整数部分为0时，无大写内容
            if (iTemp <= 1 && stringBuilder[0] == '0') {
                return intString;
            }

            //转换整数部分数字
            for (int i = iTemp; i > 0; i--) {
                Int32 num = Convert.ToInt32(stringBuilder[iTemp - i].ToString());   //获取当前数字
                stringBuilder.Append(nums[num]);    //追加大写数字
                stringBuilder.Append(bits[i + 1]);  //追加金额单位
            }

            stringBuilder.Remove(0, iTemp);  //移除原有的小写数字内容
            intString = "" + stringBuilder;

            return intString;
        }

        private string getDotString(string dotString) {
            StringBuilder stringBuilder = new StringBuilder(dotString);

            dotString = ""; //初始化string

            //转换小数部分数字
            for (int i = 2; i > 0; i--) {
                Int32 num = Convert.ToInt32(stringBuilder[2 - i].ToString());   //获取当前数字
                stringBuilder.Append(nums[num]);    //追加大写数字
                stringBuilder.Append(bits[i - 1]);  //追加金额单位
            }

            stringBuilder.Remove(0, 2);  //移除原有的小写数字内容
            dotString = "" + stringBuilder;

            return dotString;
        }

        public override string ToString() {
            string @int;    //整数字符串 int是整型标识符，不能当作变量名，需要加 " @ " 进行规避
            string dot;     //尾数字符串

            decimal money = Math.Abs(Money);   //绝对值
            //判断是否存在小数点
            int index = money.ToString().IndexOf(".");
            if (index >= 0) {
                string[] str = money.ToString().Split('.');
                @int = getIntString(str[0]);
                //小数点后不足两位补齐0
                if (str[1].Length==1) {
                    str[1] += "0";
                    dot = getDotString(str[1]);
                } else {
                    dot = getDotString(str[1]);
                }
            } else {
                /* 若输入：
                 * 123. 或 123 这类没有小数点或小数点后无数字的金额时，补0
                 * 因为decimal会自动忽略没有尾数的数字小数点
                 */
                @int = getIntString(money.ToString());
                dot = getDotString("00");
            }
            return $"{@int}{dot}";
        }

        private void btnTrans_Click(object sender, EventArgs e) {
            try {
                if (tbMoney.Text.Trim() != string.Empty) {
                    string money = tbMoney.Text.Trim().Replace(" ", "");    //删除输入内容两边和之间存在的空格
                    BigNumForm6335 bigNum = new BigNumForm6335(Convert.ToDecimal(money));
                    lbUpper.ForeColor = bigNum.Color;
                    lbUpper.Text = bigNum.ToString();         
                }
            } catch (Exception) {
                lbUpper.ForeColor = Color.Red;
                lbUpper.Text = "输入字符串的格式不正确";
            }
        }
    }
}
