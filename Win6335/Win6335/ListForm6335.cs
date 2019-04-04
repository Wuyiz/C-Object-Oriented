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
    public partial class ListForm6335 : Form {
        string sex, major;
        public ListForm6335() {
            InitializeComponent();
        }

        private void ListForm6335_Load(object sender, EventArgs e) {
            listBox1.Items.Add("男");
            listBox1.Items.Add("女");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("计算机科学与技术");
            comboBox1.Items.Add("网络工程");
            comboBox1.Items.Add("软件工程");
            comboBox1.Items.Add("通信工程");
            comboBox1.Items.Add("电子信息工程");

            checkedListBox1.Items.Add("唱歌");
            checkedListBox1.Items.Add("跳舞");
            checkedListBox1.Items.Add("打篮球");
            checkedListBox1.Items.Add("踢足球");
            checkedListBox1.Items.Add("看书");
        }

        private void button1_Click(object sender, EventArgs e) {
            string info = "";
            info = "学生信息是：姓名：" + textBox1.Text + "\t性别：" + sex + "\t所学专业是："
                + major + "\t爱好有：" + info + "\t";
            foreach (string item in checkedListBox1.CheckedItems)
            {
                info = info + item + "\t";
            }
            MessageBox.Show(info);
        }

        private void button2_Click(object sender, EventArgs e) {
            textBox1.Text = "";
            listBox1.SelectedIndex = -1;
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("唱歌");
            checkedListBox1.Items.Add("跳舞");
            checkedListBox1.Items.Add("打篮球");
            checkedListBox1.Items.Add("踢足球");
            checkedListBox1.Items.Add("看书");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            sex = listBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            major = comboBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}
