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
    public partial class SinxForm6335 : Form {
        public SinxForm6335() {
            InitializeComponent();
        }

        private void SinxForm6335_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 3);

            Point center = new Point(1, this.Height / 2);   //原点
            graphics.DrawLine(pen, center.X, 0, center.X, this.Height);    //y轴
            graphics.DrawLine(pen, 0, center.Y, this.Width, center.Y);  //x轴

            int flag = 1;   //π倍数
            int Zoom = 35;  //放大倍数

            float x1 = (float)(0 * Math.PI * Zoom / 180 + center.X);
            float y1 = (float)(Math.Sin(0 * Math.PI / 180) * Zoom + center.Y);

            //获取绘制y轴的sinx值
            for (int i = 1; i < 180 * 2 * 5; i++)
            {
                float x2 = (float)(i * Math.PI * Zoom / 180 + center.X);
                float y2 = (float)Math.Sin(i * Math.PI / 180) * (-1) * Zoom + center.Y;

                graphics.DrawLine(pen, x1, y1, x2, y2);

                //判断交点，标出π值
                if (i%180==0) { 
                    graphics.DrawString((flag == 1 ? "π" : $"{flag}π"), new Font(new FontFamily("Arial"), 15, FontStyle.Regular), new SolidBrush(Color.Red), x2, center.Y + 5);
                    flag++;
                }

                x1 = x2;
                y1 = y2;
            }
        }
    }
}
