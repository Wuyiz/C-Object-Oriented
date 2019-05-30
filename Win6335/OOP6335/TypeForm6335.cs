using System;
using System.Windows.Forms;
using Library6335;
using System.Collections.Generic;

namespace Win6335.OOP6335 {
    public partial class TypeForm6335 : Form {
        public TypeForm6335() {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] {
            "CustomerType6335",
            "Degree6335",
            "StaffState6335",
            "TourState6335",
            "Area6335",
            "SceneType6335"});
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            string selected = comboBox1.SelectedItem.ToString();    //获取下拉列表中的枚举类型名称
            IEnumerator<string> result = ReadFromEnum6335.AllInformation6335(selected).GetEnumerator(); //将结果传入集合

            string[] text = new string[10]; //定义一个存放枚举集合值的数组

            int i = 0;
            //MoveNext 将 Current 设置为下一个元素
            while (result.MoveNext()) {
                text[i++] = result.Current; //遍历结果集，传入集合当前位置元素到数组
            }

            textBox1.Lines = text;  //显示
        }
    }
}
