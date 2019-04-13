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
    public partial class ControlsForm6335 : Form {
        string gender;  //性别
        string identity;    //政治面貌

        public ControlsForm6335() {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            cboCity.Items.Clear();

            switch (cboProvince.Text) {
                case "福建省":
                    cboCity.Items.Add("福州市");
                    cboCity.Items.Add("厦门市");
                    cboCity.Items.Add("三明市");
                    break;
                case "甘肃省":
                    cboCity.Items.Add("兰州市");
                    cboCity.Items.Add("金昌市");
                    cboCity.Items.Add("酒泉市");
                    break;
                case "陕西省":
                    cboCity.Items.Add("西安市");
                    cboCity.Items.Add("宝鸡市");
                    cboCity.Items.Add("咸阳市");
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            lbInfo.Items.Clear();   //清空信息面板
            Boolean flag = true;    //bool=true时才能显示信息
            if (idCount(mtbNum) != 6) {
                //判断学号规范性
                MessageBox.Show("请输入6位学号！", "Error");
                mtbNum.Focus();
                flag = false;
            } else if (tbName.Text.Trim() == string.Empty) {
                //判断学号规范性
                MessageBox.Show("请输入姓名！", "Error");
                tbName.Focus();
                flag = false;
            }
            if (flag) {
                if (rbGender1.Checked) {    //获取性别信息
                    gender = rbGender1.Text;
                } else if (rbGender2.Checked) {
                    gender = rbGender2.Text;
                }
                if (rbIdentity1.Checked) {  //获取政治面貌信息
                    identity = rbIdentity1.Text;
                } else if (rbIdentity2.Checked) {
                    identity = rbIdentity2.Text;
                } else if (rbIdentity3.Checked) {
                    identity = rbIdentity3.Text;
                }
                lbInfo.Items.Add($"{label1.Text.Replace("&X", "")}:{mtbNum.Text}");
                lbInfo.Items.Add($"{label2.Text.Replace("&E", "")}:{tbName.Text}");
                lbInfo.Items.Add($"{label3.Text.Replace("&D", "")}:{dtBirthday.Text}");
                lbInfo.Items.Add($"{label4.Text}:{gender.Remove(1)}");
                lbInfo.Items.Add($"{label5.Text.Replace("&M", "")}:{cboNational.Text.Replace("&M","")}");
                lbInfo.Items.Add($"{groupBox1.Text}:{identity.Remove(2)}");
                lbInfo.Items.Add($"{groupBox2.Text}:{cboProvince.Text},{cboCity.Text}");
            }
        }
        private void button2_Click(object sender, EventArgs e) {
            mtbNum.Clear(); //学号
            tbName.Clear(); //姓名
            dtBirthday.Value = DateTime.Today;  //恢复默认系统时间
            cboNational.SelectedIndex = -1; //重置民族菜单
            cboProvince.SelectedIndex = -1; //重置籍贯菜单
            rbGender1.Checked = true;   //性别
            rbIdentity3.Checked = true; //政治面貌
        }

        public static int idCount(MaskedTextBox masked) {
            int count = 0;
            char[] charArr = masked.Text.ToCharArray();

            for (int i = 0; i < charArr.Length; i++) {
                if (charArr[i] != ' ') {
                    count++;
                }
            }
            return count;
        }

        private void ControlsForm6335_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult dr;

            dr = MessageBox.Show("是否保存后关闭窗口？", "吴沂章",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes) {
                MessageBox.Show("已保存", "吴沂章");
            } else if (dr == DialogResult.Cancel) {
                e.Cancel = true;
            }
            
        }
    }
}
