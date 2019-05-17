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
                new Student6335{ Name="王麻子", ID="109", Score=421, Source="三明" },
                new Student6335{ Name="李狗蛋", ID="106", Score=336, Source="厦门" },
                new Student6335{ Name="李一田", ID="105", Score=456, Source="长乐" },
                new Student6335{ Name="刘莉莉", ID="109", Score=407, Source="长乐" },
                new Student6335{ Name="林保", ID="107", Score=388, Source="厦门" },
                new Student6335{ Name="林书浩", ID="108", Score=298, Source="三明" },
                new Student6335{ Name="李玲", ID="115", Score=567, Source="厦门" },
                new Student6335{ Name="张主强", ID="010", Score=666, Source="泉州" },
                new Student6335{ Name="陈红", ID="110", Score=449, Source="三明" },
                new Student6335{ Name="杨宇箫", ID="112", Score=250, Source="福州" },
                new Student6335{ Name="陈远军", ID="123", Score=456, Source="泉州" },
                new Student6335{ Name="林锃寒", ID="233", Score=478, Source="长乐" },
                new Student6335{ Name="田晋中", ID="120", Score=521, Source="福州" },
            };
            return Students;
        }

        private void rbID_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "按学号排序，输出所有属性：";
            var select = from s in Students
                            orderby s.ID
                            select s;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = new BindingSource(select, null);
        }

        private void rbName_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "按姓名排序,列出学号、姓名：";
            var select = from s in Students
                            orderby s.Name
                            select new { s.ID, s.Name };
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (var item in select) {
                listBox1.Items.Add($"{item.ID}\t{item.Name}");
            }
        }

        private void rbScore_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "按成绩排序，列出学号，姓名，成绩：";
            var select = from s in Students
                         orderby s.Score
                         select new { s.ID, s.Name ,s.Score };
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (var item in select) {
                listBox1.Items.Add($"{item.ID}\t{item.Name}\t{item.Score}");
            }
        }

        private void rbSource_CheckedChanged(object sender, EventArgs e) {
            label1.Text = "按生源地排序，列出学号、姓名、生源地：";
            var select = from s in Students
                         orderby s.Source
                         select new { s.ID, s.Name, s.Source };
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (var item in select) {
                listBox1.Items.Add($"{item.ID}\t{item.Name}\t{item.Source}");
            }
        }

        private void btnList_li_Click(object sender, EventArgs e) {
            label1.Text = "姓李的学生名单:";
            var select = from s in Students
                         where s.Name.StartsWith("李")
                         select s;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (var item in select) {
                listBox1.Items.Add(item);
            }
        }

        private void btnXiamen_stu_Click(object sender, EventArgs e) {
            label1.Text = "来自厦门的学生:";
            var select = from s in Students
                         where s.Source == "厦门"
                         select s;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (var item in select) {
                listBox1.Items.Add(item);
            }
        }

        private void btnCount_source_Click(object sender, EventArgs e) {
            label1.Text = "按生源地统计，并按人数降序排列：";
            var select = from s in Students
                         group s by s.Source into temp
                         orderby temp.Count() descending
                         select temp;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (var item in select) {
                listBox1.Items.Add($"{item.Key}\t{item.Count()}");
            }
        }

        private void btn400_Click(object sender, EventArgs e) {
            label1.Text = "400分以上的名单:";
            var select = from s in Students
                         where s.Score > 400
                         select s;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (var item in select) {
                listBox1.Items.Add(item);
            }
        }
    }
}
