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
    public partial class ArrayForm : Form {
        public ArrayForm() {
            InitializeComponent();
        }


        private void ArrayForm_Load(object sender, EventArgs e) {
            //string[] txt = { "textbox", "lines", "abo", "ac", "aaa","ab" };
            //textBox1.Lines = txt;
        }
        private void button1_Click(object sender, EventArgs e) {
            string[] arr = textBox1.Lines;
            Array.Sort(arr);
            textBox2.Lines = arr;
        }

        private void button2_Click(object sender, EventArgs e) {
            label3.Text = "数组中共有"+textBox1.Lines.Count()+"个元素";
        }

        private void button3_Click(object sender, EventArgs e) {
            string[] arr = textBox1.Lines;
            string wordkey = textBox3.Text;
            int index = Array.IndexOf(arr, wordkey);
            if (index>=0) {
                label4.Text = "数组中的第"+(index+1)+"个元素";
            } else {
                label4.Text = "找不到！";
            }
        }
    }
}
