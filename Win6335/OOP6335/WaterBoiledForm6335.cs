using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library6335;

namespace Win6335.OOP6335 {
    public partial class WaterBoiledForm6335 : Form {
        public WaterBoiledForm6335() {
            InitializeComponent();
        }

        /// <summary>
        /// 创建事件源对象：热水器
        /// 创建事件接收者：报警器、显示器
        /// 订阅热水器的WaterBoiled事件
        /// 调用Heating方法，热水器开始加热
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            listBox1.Items.Add("开始加热了……");

            Heater6335 heater6335 = new Heater6335();
            Display6335 display6335 = new Display6335(listBox1);    
            heater6335.WaterBoiled += Alarm6335.MakeAlert6335;  //订阅报警器事件
            heater6335.WaterBoiled += display6335.ShowMsg;  //订阅显示器事件
            heater6335.Heating();   //启动热水器

            listBox1.Items.Add("");

        }
    }
}
