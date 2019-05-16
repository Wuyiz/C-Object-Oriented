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
    public partial class LINQForm6335 : Form {
        public LINQForm6335() {
            InitializeComponent();
            BuildStudents6335();
            dataGridView1.DataSource = Students;
        }

        private List<Student6335> Students;

        public List<Student6335> BuildStudents6335() {
            Students = new List<Student6335>() {
                new Student6335{ Name="张三", ID="101", Score=430, Source="三明" },
                new Student6335{ Name="李四", ID="102", Score=625, Source="福州" },
                new Student6335{ Name="王麻子", ID="103", Score=421, Source="三明" },
                new Student6335{ Name="李狗蛋", ID="104", Score=336, Source="厦门" },
                new Student6335{ Name="李一田", ID="105", Score=456, Source="长乐" },
                new Student6335{ Name="刘莉莉", ID="106", Score=407, Source="长乐" },
                new Student6335{ Name="林保", ID="107", Score=388, Source="厦门" },
                new Student6335{ Name="超勇名", ID="108", Score=298, Source="三明" },
                new Student6335{ Name="李玲", ID="109", Score=567, Source="厦门" },
                new Student6335{ Name="张主强", ID="110", Score=666, Source="泉州" },
                new Student6335{ Name="陈红", ID="111", Score=449, Source="三明" },
                new Student6335{ Name="杨宇箫", ID="112", Score=250, Source="福州" },
                new Student6335{ Name="陈远军", ID="113", Score=456, Source="泉州" },
                new Student6335{ Name="林锃寒", ID="114", Score=478, Source="长乐" },
                new Student6335{ Name="田晋中", ID="115", Score=521, Source="福州" },
            };
            return Students;
        }

        private void rbID_CheckedChanged(object sender, EventArgs e) {
            var select_id = from student in Students
                            orderby student.ID
                            select student;
            listBox1.Items.Clear();
            listBox1.DataSource = select_id;
        }

        private void rbName_CheckedChanged(object sender, EventArgs e) {

        }

        private void rbScore_CheckedChanged(object sender, EventArgs e) {

        }

        private void rbSource_CheckedChanged(object sender, EventArgs e) {

        }

        private void btnList_li_Click(object sender, EventArgs e) {

        }

        private void btnXiamen_stu_Click(object sender, EventArgs e) {

        }

        private void btnCount_source_Click(object sender, EventArgs e) {

        }

        private void btn400_Click(object sender, EventArgs e) {

        }
    }
}
