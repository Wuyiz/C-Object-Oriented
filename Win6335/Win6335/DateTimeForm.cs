using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335.Win6335 {
    public partial class DateTimeForm : Form {
        private int year;   //年份
        private int month;  //月份
        private int day;    //日
        private int dnum;   //天数
        DateTime dt;

        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }
        public int Dnum { get => dnum; set => dnum = value; }

        public DateTimeForm() {
            InitializeComponent();
        }

        private void DateTimeForm_Load(object sender, EventArgs e) {
            //txtYear.Text = 2019.ToString();
            //txtMonth.Text = 4.ToString();
            //txtDay.Text = 5.ToString();
            //txtSpan.Text = 3333.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (txtYear.Text != string.Empty && txtMonth.Text != string.Empty && txtDay.Text != string.Empty)
            {
                Year = Convert.ToInt32(txtYear.Text);
                Month = Convert.ToInt32(txtMonth.Text);
                Day = Convert.ToInt32(txtDay.Text);
                string dateTxt = string.Format("{0}-{1}-{2}", Year, Month, Day);

                if (DateTime.TryParse(dateTxt, out dt))
                {
                    lblWeek.Text = dt.DayOfWeek.ToString();
                } else
                {
                    lblWeek.Text = "请在年、月、日中输入数字!";
                }
            } else
            {
                lblWeek.Text = "请在年、月、日中输入数字!";
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (txtYear.Text != string.Empty && txtMonth.Text != string.Empty && txtDay.Text != string.Empty && txtSpan.Text != string.Empty)
            {
                Year = Convert.ToInt32(txtYear.Text);
                Month = Convert.ToInt32(txtMonth.Text);
                Day = Convert.ToInt32(txtDay.Text);
                Dnum = Convert.ToInt32(txtSpan.Text);

                string dateTxt = string.Format("{0}-{1}-{2}", Year, Month, Day);

                if (DateTime.TryParse(dateTxt, out dt))
                {
                    lblDate.Text = dt.AddDays(Convert.ToInt32(txtSpan.Text)).ToString("yyyy年MM月dd日 dddd");

                } else
                {
                    lblDate.Text = "请输入要计算的天数!";
                }
            } else
            {
                lblDate.Text = "请输入要计算的天数!";
            }          
        }

        //禁止在textBox输入框输入非法字符
        private void keypressed(Object o, KeyPressEventArgs e) {
            if (e.KeyChar != '\b')//这是允许输入退格键 
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字 
                {
                    e.Handled = true;

                }
            }
        }
    }
}
