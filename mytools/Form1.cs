using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mytools {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string str = textBox1.Text;
            string[] arr = str.Split(textBox2.Text.ToCharArray());
            str = "";
            foreach (var item in arr) {
                str += item + " ";
            }
            textBox3.Text = str;
            //try {
            //    string path = $@"C:\Users\AllureLove\Desktop\";
            //    var filename = $"wuyiz{DateTime.Now:yyyy-MM-dd dddd}.txt";
            //    if (!Directory.Exists(path))
            //        Directory.CreateDirectory(path);
            //    TextWriter tw = new StreamWriter(Path.Combine(path, filename), true); //true在文件末尾添加数据

            //    tw.WriteLine($"----产生时间：{DateTime.Now:yyyy-MM-dd HH:mm:ss}---------------------------------------------------------------------");

            //    //tw.WriteLine(data.ToJsonStr());
            //    //tw.WriteLine(arr.Length);

            //    tw.WriteLine(str);
            //    tw.Close();
            //} catch (Exception) {

            //}
        }

        private void Form1_Load(object sender, EventArgs e) {
            string str = "汉族、蒙古族、回族、藏族、维吾尔族、苗族、彝族、壮族、" +
                    "布依族、朝鲜族、满族、侗族、瑶族、白族、土家族、哈尼族、" +
                    "哈萨克族、傣族、黎族、傈僳族、佤族、畲族、高山族、拉祜族、" +
                    "水族、东乡族、纳西族、景颇族、柯尔克孜族、土族、达斡尔族、" +
                    "仫佬族、羌族、布朗族、撒拉族、毛南族、仡佬族、锡伯族、阿昌族、" +
                    "普米族、塔吉克族、怒族、乌孜别克族、俄罗斯族、鄂温克族、德昂族、" +
                    "保安族、裕固族、京族、塔塔尔族、独龙族、鄂伦春族、赫哲族、门巴族、" +
                    "珞巴族、基诺族";
            textBox1.Text = str;
            textBox2.Text = "、";
        }
    }
}
