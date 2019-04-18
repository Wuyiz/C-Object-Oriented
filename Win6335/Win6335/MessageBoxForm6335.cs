using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335.Win6335
{
    public partial class MessageBoxForm6335 : Form
    {
        public MessageBoxForm6335()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("测试一下消息对话框！", "测试测试",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr==DialogResult.Yes)
            {
                MessageBox.Show("你选择的为“是”按钮", "吴沂章");
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("你选择的为“否”按钮", "吴沂章");
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("你选择的为“取消”按钮", "吴沂章");
            }
            else
            {
                MessageBox.Show("你没有进行任何的操作！", "吴沂章");
            }
        }
    }
}
