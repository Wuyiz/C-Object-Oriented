﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335 {
    public partial class MainForm6335 : Form {
        public MainForm6335() {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) {
            Win6335.BaseForm6335 baseForm = new Win6335.BaseForm6335();
            baseForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            Win6335.ListForm6335 list = new Win6335.ListForm6335();
            list.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            Win6335.DateTimeForm dateTime = new Win6335.DateTimeForm();
            dateTime.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e) {
            Win6335.EditorForm6335 editor = new Win6335.EditorForm6335();
            editor.Show();
        }

        private void button5_Click(object sender, EventArgs e) {
            Win6335.MessageBoxForm6335 messageBox = new Win6335.MessageBoxForm6335();
            messageBox.Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            Win6335.ControlsForm6335 controlsForm = new Win6335.ControlsForm6335();
            controlsForm.Show();
        }

        private void button7_Click(object sender, EventArgs e) {
            Win6335.ArrayForm array = new Win6335.ArrayForm();
            array.Show();
        }

        private void button8_Click(object sender, EventArgs e) {
            Win6335.CloseForm6335 close = new Win6335.CloseForm6335();
            close.Show();
        }
    }
}
