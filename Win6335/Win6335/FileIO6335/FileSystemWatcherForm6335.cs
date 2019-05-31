using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335.Win6335.FileIO6335 {
    public partial class FileSystemWatcherForm6335 : Form {
        //定义监视成员变量
        FileSystemWatcher watcher = new FileSystemWatcher();

        public FileSystemWatcherForm6335() {
            InitializeComponent();
            //获取监视操作枚举名称
            cklbAction.Items.AddRange(Enum.GetNames(typeof(NotifyFilters)));
            //添加事件句柄
            //当由FileSystemWatcher所指定的路径中的文件或目录的
            //大小、系统属性、最后写入时间、最后访问时间或安全权限
            //发生更改时，更改事件就会发生
            watcher.Changed += new FileSystemEventHandler(FileChanged6335);
            //由FileSystemWatcher所指定的路径中文件或目录被创建时，创建事件发生
            watcher.Created += new FileSystemEventHandler(FileChanged6335);
            //由FileSystemWatcher所指定的路径中文件或目录被删除时，删除事件发生
            watcher.Deleted += new FileSystemEventHandler(FileChanged6335);
            //由FileSystemWatcher所指定的路径中文件或目录被重命名时，重命名事件发生
            watcher.Renamed += new RenamedEventHandler(FileRenamed6335);

            tbPath.Text = @"C:\Users\AllureLove\Desktop";
            tbFilterType.Text = @"*.txt";
        }

        /// <summary>
        /// 浏览文件并将源文件路径显示在文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_file_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹";  //设置对话框说明

            if (dialog.ShowDialog() == DialogResult.OK) {
                tbPath.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 开始 / 停止监视
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOn_Off_Click(object sender, EventArgs e) {
            //判断监听是否启用
            if (!watcher.EnableRaisingEvents) {
                try {
                    //设置监听的路径(若为空，抛异常)
                    watcher.Path = string.IsNullOrEmpty(tbPath.Text) ? throw new Exception() : tbPath.Text;
                    //设置监听文件类型(若为空，抛异常)
                    watcher.Filter = string.IsNullOrEmpty(tbFilterType.Text) ? throw new Exception() : tbFilterType.Text;

                    //枚举值为2的次幂时，可以使用与位或
                    //NotifyFilters的枚举值为1，2，4，8，16，32，64，256
                    //因为没有2^7枚举值，所以当用户选到Security时，选择值7要变为8
                    //将所有值相加，得到枚举值总和，赋值给枚举NotifyFilters，得到叠加值
                    //其中NotifyFilter默认值为：NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite
                    int enum_val = 0;
                    for (int i = 0; i < cklbAction.Items.Count; i++) {
                        if (cklbAction.GetItemChecked(i)) {
                            //NotifyFilters notify = (NotifyFilters)Enum.Parse(typeof(NotifyFilters), cklbAction.Items[i].ToString());
                            enum_val += (int)Math.Pow(2, (i == 7) ? 8 : i);
                        }
                    }
                    //通过数值获取枚举类叠加值
                    NotifyFilters notify = (NotifyFilters)enum_val;
                    //添加监视选项
                    watcher.NotifyFilter = notify;

                    //启用监视
                    watcher.EnableRaisingEvents = true;
                    //当监听开始时，修改按钮名称
                    btnOn_Off.Text = "停止监视";
                } catch (Exception) {
                    MessageBox.Show("请选择路径或监视文件");
                    return;
                }
            } else {
                //停止监视
                watcher.EnableRaisingEvents = false;

                //当监听停止时，修改按钮名称
                if (!watcher.EnableRaisingEvents) {
                    btnOn_Off.Text = "开始监视";
                }
            }
        }

        /// <summary>
        /// 清除监视内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e) {
            tbDisplay.Clear();
        }

        /// <summary>
        /// 定义FileChanged6335事件处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileChanged6335(object sender, FileSystemEventArgs e) {
            //指定当文件被更改、创建或删除时要做的事
            string temp = $"{e.ChangeType}: {e.FullPath}\r\n";
            Action<string> action = ShowLog;
            //请求UI主线程（窗体）执行ShowLog方法
            this.Invoke(action, temp);
        }

        /// <summary>
        /// 将日志信息显示在文本框中
        /// </summary>
        /// <param name="text"></param>
        private void ShowLog(string text) {
            tbDisplay.AppendText(text);
        }

        /// <summary>
        /// 定义FileRenamed6335事件处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileRenamed6335(object sender, RenamedEventArgs e) {
            //指定当文件被重命名时发生的动作
            string temp = $"{e.ChangeType}: {e.OldFullPath} -> {e.FullPath}\r\n";
            Action<string> action = ShowLog;
            //请求UI主线程（窗体）执行ShowLog方法
            this.Invoke(action, temp);
        }
    }
}
