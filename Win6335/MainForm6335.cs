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
            tabPage1.Text = "Window";
            tabPage2.Text = "OOP";
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

        private void button9_Click(object sender, EventArgs e) {
            GDI6335.LineForm6335 line = new GDI6335.LineForm6335();
            line.Show();
        }

        private void button11_Click(object sender, EventArgs e) {
            GDI6335.PieForm6335 pie = new GDI6335.PieForm6335();
            pie.Show();
        }

        private void button10_Click(object sender, EventArgs e) {
            GDI6335.StarForm6335 star = new GDI6335.StarForm6335();
            star.Show();
        }

        private void button12_Click(object sender, EventArgs e) {
            GDI6335.CheckCodeForm6335 checkCode = new GDI6335.CheckCodeForm6335();
            checkCode.Show();
        }

        private void button13_Click(object sender, EventArgs e) {
            GDI6335.SinxForm6335 sinx = new GDI6335.SinxForm6335();
            sinx.Show();
        }

        private void button14_Click(object sender, EventArgs e) {
            OOP6335.BigNumForm6335 bigNum = new OOP6335.BigNumForm6335();
            bigNum.Show();
        }

        private void button15_Click(object sender, EventArgs e) {
            OOP6335.ComplexForm6335 complex = new OOP6335.ComplexForm6335();
            complex.Show();
        }

        private void button16_Click(object sender, EventArgs e) {
            OOP6335.TypeForm6335 type = new OOP6335.TypeForm6335();
            type.Show();
        }

        private void button18_Click(object sender, EventArgs e) {
            OOP6335.LINQForm6335 LINQ = new OOP6335.LINQForm6335();
            LINQ.Show();
        }

        private void button17_Click(object sender, EventArgs e) {
            OOP6335.DeckForm6335 deck = new OOP6335.DeckForm6335();
            deck.Show();
        }

        private void button20_Click(object sender, EventArgs e) {
            OOP6335.DelegateForm6335 @delegate = new OOP6335.DelegateForm6335();
            @delegate.Show();
        }

        private void button19_Click(object sender, EventArgs e) {
            OOP6335.WaterBoiledForm6335 waterBoiled = new OOP6335.WaterBoiledForm6335();
            waterBoiled.Show();
        }

        private void button21_Click(object sender, EventArgs e) {
            FileIO6335.EncodingForm6335 encoding = new FileIO6335.EncodingForm6335();
            encoding.Show();
        }

        private void button22_Click(object sender, EventArgs e) {
            FileIO6335.FileSystemWatcherForm6335 fileSystemWatcher = new FileIO6335.FileSystemWatcherForm6335();
            fileSystemWatcher.Show();
        }

        private void button23_Click(object sender, EventArgs e) {
            DB6335.ADONETForm6335 aDONET = new DB6335.ADONETForm6335();
            aDONET.Show();
        }

        private void button24_Click(object sender, EventArgs e) {
            DB6335.Linq2SqlForm6335 linq2Sql = new DB6335.Linq2SqlForm6335();
            linq2Sql.Show();
        }
    }
}
