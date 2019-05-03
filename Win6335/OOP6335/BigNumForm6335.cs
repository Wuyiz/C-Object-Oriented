using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library6335;

namespace Win6335.OOP6335 {
    public partial class BigNumForm6335 : Form {

        public BigNumForm6335() {
            InitializeComponent();
        }

        private void btnTrans_Click(object sender, EventArgs e) {
            try {
                if (tbMoney.Text.Trim() != string.Empty) {
                    string money = tbMoney.Text.Replace(" ", "");    //删除输入内容两边和之间存在的空格
                    BigNum6335 bigNum = new BigNum6335();
                    bigNum.Money = Convert.ToDecimal(money);
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
