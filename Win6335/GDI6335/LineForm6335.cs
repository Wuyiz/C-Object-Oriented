﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335.GDI6335 {
    public partial class LineForm6335 : Form {
        public LineForm6335() {
            InitializeComponent();
        }

        private void LineForm6335_Paint(object sender, PaintEventArgs e) {
            Graphics g = this.CreateGraphics(); //创建Graphics对象
            int halfWidth = this.Width / 2;
            int halfHeight = this.Height / 2;
            Pen pen = new Pen(Color.Blue,2);    //创建画笔
            AdjustableArrowCap arrow = new AdjustableArrowCap(8,8,false);   //定义画笔线帽
            pen.CustomEndCap = arrow;
            g.DrawLine(pen,50,halfHeight-20,Width-50,halfHeight-20);    //画横坐标
            g.DrawLine(pen, halfWidth, Height - 60, halfWidth, 20); //画纵坐标
        }
    }
}
