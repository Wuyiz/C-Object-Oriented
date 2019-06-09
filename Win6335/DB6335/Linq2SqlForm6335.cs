using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335.DB6335 {
    public partial class Linq2SqlForm6335 : Form {
        DataContext db;
        public Linq2SqlForm6335() {
            InitializeComponent();
            //铺满
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            db = new DataContext(Properties.Settings.Default.StudentConnectionString);
            dataGridView1.DataSource = db.GetTable<Student6335>();
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            Student6335 student = new Student6335 {
                No = "9999",
                Name = "新同学"
            };
            db.GetTable<Student6335>().InsertOnSubmit(student);
            db.SubmitChanges();
;        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            Table<Student6335> stuList = db.GetTable<Student6335>();
            var query = from stu in stuList
                        where stu.Name.Length == 2
                        select stu;
            foreach (var item in query) {
                item.Sex = '男';
            }
            foreach (var item in stuList) {
                if (item.ID < 10) {
                    item.Age = item.ID;
                }
            }
            db.SubmitChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            Table<Student6335> stuList = db.GetTable<Student6335>();
            var query = from stu in stuList
                        where stu.No.Trim() == "9999"
                        select stu;
            foreach (var item in query) {
                stuList.DeleteOnSubmit(item);
            }
            db.SubmitChanges();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            //db.SubmitChanges()后，要重新创建供绑定的数据源
            dataGridView1.DataSource = db.GetTable<Student6335>().GetNewBindingList();
        }
    }
}
