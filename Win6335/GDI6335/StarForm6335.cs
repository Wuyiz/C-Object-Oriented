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
    public partial class StarForm6335 : Form {
        public StarForm6335() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Graphics g = this.CreateGraphics(); //创建绘图对象
            Pen pen = new Pen(Color.Red);   //创建画笔对象
            g.DrawPolygon(pen, GetPoints(new PointF(170, 150)));    //绘制空心五角心
        }

        private void button2_Click(object sender, EventArgs e) {
            Graphics g = this.CreateGraphics(); //创建绘图对象
            Brush brush = new SolidBrush(Color.Red);   //创建画刷对象
            g.FillPolygon(brush, GetPoints(new PointF(400, 150)));   //绘制实心五角心
        }

        //获取一系列点的坐标，ptCenter表示中心点，length表示距离中心点的长度，angles表示两点之间的夹角
        private PointF[] GetPoint(PointF ptCenter,double length,params double[] angles) {
            PointF[] points = new PointF[angles.Length];
            for (int i = 0; i < points.Length; i++) {
                //获取各个顶点的坐标
                points[i] = new PointF((float)(ptCenter.X + length * Math.Cos(angles[i])), (float)(ptCenter.Y + length * Math.Sin(angles[i])));
            }
            return points;
        }

        //获取所有角度的数组，startAngle表示开始角度，pointed表示个数
        private double[] GetAngles(double startAngle, int pointed) {
            double[] angles = new double[pointed];
            angles[0] = startAngle; //设置开始角度

            for (int i = 1; i < angles.Length; i++) {
                //设置所有角度，其中 2 * Math.PI / pointed 为角度增量
                angles[i] = angles[i - 1] + 2 * Math.PI / pointed;
            }
            return angles;
        }

        //获取五角星的所有顶点坐标
        private PointF[] GetPoints(PointF point) {
            double[] angles_1 = GetAngles(-Math.PI / 2, 5); //五角星外围的点的角度数组
            double[] angles_2 = GetAngles(-Math.PI / 2 + Math.PI / 5, 5); //五角星内围的点的角度数组
            PointF[] point_1 = GetPoint(point, 80, angles_1);   //五角星外围的点的数组
            PointF[] point_2 = GetPoint(point, 40, angles_2);   //五角星内围的点的数组
            PointF[] points = new PointF[point_1.Length + point_2.Length];

            //合成五角星所有点的数组
            for (int i = 0, j = 0; i < points.Length; i+=2, j++) {
                points[i] = point_1[j];
                points[i + 1] = point_2[j];
            }
            return points;
        }
    }
}
