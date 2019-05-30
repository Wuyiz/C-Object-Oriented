using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Win6335.Win6335.FileIO6335 {
    public partial class EncodingForm6335 : Form {
        public EncodingForm6335() {
            InitializeComponent();
            cmbEncoding.Items.AddRange(new Encoding[] {
                Encoding.Default,
                Encoding.ASCII,
                Encoding.Unicode,
                Encoding.UTF32,
                Encoding.UTF7,
                Encoding.UTF8
            });
            cmbEncoding.SelectedIndex = 0;
            tbInput.Text = $@"使用{cmbEncoding.Text}，该类为抽象类";
            tbFile_name.Text = "wuyiz.txt";

        }

        private void btnWrite_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(tbFile_name.Text.Trim())) {
                MessageBox.Show("请设置写入文件名称!");
                return;
            }

            //获取下拉列表中选中的编码格式
            Encoding encoding = (Encoding)cmbEncoding.SelectedItem;
            //创建FileStream
            FileStream fsWrite = new FileStream(tbFile_name.Text, FileMode.OpenOrCreate, FileAccess.Write);
            //得到字节数组
            byte[] buffer = encoding.GetBytes(tbInput.Text);
            //写入文件
            fsWrite.Write(buffer, 0, buffer.Length);
            //关闭流
            fsWrite.Close();
            //释放资源
            fsWrite.Dispose();

            //显示文件目录
            //MessageBox.Show($"文件位置：{Environment.CurrentDirectory}\\{tbFile_name.Text}");
        }

        private void btnRead_Click(object sender, EventArgs e) {
            //创建FileStream
            using (FileStream fsRead = new FileStream(tbFile_name.Text, FileMode.OpenOrCreate, FileAccess.Read)) {
                byte[] buffer = new byte[50];
                int fsLen = 0;
                tbDisplay.Clear();

                Encoding encoding = (Encoding)cmbEncoding.SelectedItem;
                //从文件中读取字节数组
                while ((fsLen = fsRead.Read(buffer, 0, buffer.Length)) != 0) {
                    tbDisplay.Text += encoding.GetString(buffer, 0, fsLen);
                }
            }
        }
    }
}
