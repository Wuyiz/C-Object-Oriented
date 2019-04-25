using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335.GDI6335 {
    public partial class PieForm6335 : Form {
        public PieForm6335() {
            InitializeComponent();
        }

        private void PieForm6335_Paint(object sender, PaintEventArgs e) {
            int[] saleNum = { 300, 500, 400 };
            //获取总销量和各月的单月销量
            int sum = 0, threeNum = 0, fourNum = 0, fiveNum = 0;

            for (int i = 0; i < saleNum.Length; i++) {
                sum += saleNum[i];
                if (i==0) {
                    threeNum = saleNum[0];
                } else if (i==1) {
                    fourNum = saleNum[1];
                } else {
                    fiveNum = saleNum[2];
                }
            }

            Graphics g = this.CreateGraphics();

            //清空背景色
            g.Clear(Color.LightBlue);
            Pen pen1 = new Pen(Color.Red);  //实例化Pen类

            //创建4个Brush对象用于设置颜色
            Brush brush = new SolidBrush(Color.Black);
            Brush brush2 = new SolidBrush(Color.Blue);
            Brush brush3 = new SolidBrush(Color.Wheat);
            Brush brush4 = new SolidBrush(Color.Orange);

            //创建Font对象用于设置字体
            Font font = new Font("Courier New", 12);
            int piex = 80, piey = 70, piew = 200, pieh = 200;

            //3月份销量在圆中分配的角度
            float angle_1 = Convert.ToSingle((360 / Convert.ToSingle(sum)) * Convert.ToSingle(threeNum));
            //4月份销量在圆中分配的角度
            float angle_2 = Convert.ToSingle((360 / Convert.ToSingle(sum)) * Convert.ToSingle(fourNum));
            //5月份销量在圆中分配的角度
            float angle_3 = Convert.ToSingle((360 / Convert.ToSingle(sum)) * Convert.ToSingle(fiveNum));

            g.FillPie(brush2, piex, piey, piew, pieh, 0, angle_1);  //绘制3月份销量占比
            g.FillPie(brush3, piex, piey, piew, pieh, angle_1, angle_2);  //绘制4月份销量占比
            g.FillPie(brush4, piex, piey, piew, pieh, angle_1+ angle_2, angle_3);  //绘制5月份销量占比

        }
    }
}
