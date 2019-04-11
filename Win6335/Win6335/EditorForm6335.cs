using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335.Win6335
{
    public partial class EditorForm6335 : Form
    {
        public EditorForm6335()
        {
            InitializeComponent();
        }

        private void EditorForm6335_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "富文件(*.rtf) | *.rtf";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"c:\";
            saveFileDialog1.Filter = "富文件(*.rtf) | *.rtf";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
               richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
