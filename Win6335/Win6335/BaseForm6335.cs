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
    public partial class BaseForm6335 : Form {
        public BaseForm6335() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            float kg, g, jin;
            kg = float.Parse(textBox1.Text);
            g = kg * 1000;
            textBox2.Text = g.ToString();
            jin = g / 500;
            textBox3.Text = jin.ToString();
            textBox4.Text = kg.ToString();
        }
    }
}
