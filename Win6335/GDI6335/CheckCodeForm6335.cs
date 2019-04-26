using System;
using System.Drawing;
using System.Windows.Forms;

namespace Win6335.GDI6335 {
    public partial class CheckCodeForm6335 : Form {
        public CheckCodeForm6335() {
            InitializeComponent();
        }

        private void picbVerify_Click(object sender, EventArgs e) {
            string[] str = new string[5];
            string[] font = { "Segoe Script", "微软雅黑", "华文隶书", "华文行楷", "Tempus Sans ITC", "Ravie" };
            Color[] color = { Color.DarkBlue, Color.Red, Color.Black, Color.SaddleBrown, Color.DarkGreen, Color.Violet, Color.Pink, Color.DeepSkyBlue, Color.DarkRed};

            Bitmap btm = new Bitmap(picbVerify .Width, picbVerify.Height);
            Graphics graphics = Graphics.FromImage(btm);
            Random r = new Random();

            //获取随机数
            for (int i = 0; i < str.Length; i++) {
                str[i] = r.Next(0, 10).ToString();
            }

            //画验证码
            for (int i = 0; i < 5; i++) {
                Font f = new Font(font[r.Next(0, font.Length)], r.Next(30, 35), FontStyle.Regular);
                Brush brush = new SolidBrush(color[r.Next(0, color.Length)]);
                graphics.DrawString(str[i].ToString(), f, brush, new Point(35*(i+1)-20, btm.Height / 4));
            }

            //干扰线
            for (int i = 0; i < 20; i++) {
                Pen pen = new Pen(color[r.Next(0, color.Length)]);
                graphics.DrawLine(pen, new Point(r.Next(0, btm.Width), r.Next(0, btm.Height)), new Point(r.Next(0, btm.Width), r.Next(0, btm.Height)));
            }

            //干扰点
            for (int i = 0; i < 1000; i++) {
                btm.SetPixel(r.Next(0, btm.Width), r.Next(0, btm.Height), color[r.Next(0, color.Length)]);
            }
            
            picbVerify.Image = btm;
        }
    }
}
