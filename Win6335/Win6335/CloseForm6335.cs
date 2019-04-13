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
    public partial class CloseForm6335 : Form {
        public CloseForm6335() {
            InitializeComponent();
        }

        private void CloseForm6335_FormClosing(object sender, FormClosingEventArgs e) {
            if (textBox1.Text.Trim() != string.Empty) {
                DialogResult dr;

                dr = MessageBox.Show("窗口中有未保存的数据，是否保存？", "吴沂章",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes) {
                    MessageBox.Show("已保存", "吴沂章");
                } else if (dr == DialogResult.No) {
                    MessageBox.Show("放弃修改", "吴沂章");
                } else if (dr == DialogResult.Cancel) {
                    e.Cancel = true;
                } else {
                    MessageBox.Show("你没有进行任何的操作！", "吴沂章");
                }
            }
        }
    }
}
