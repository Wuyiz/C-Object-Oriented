using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win6335.Win6335.DB6335 {
    public partial class ADONETForm6335 : Form {
        Form form = null;   //定义判断窗体是否在加载状态
        public ADONETForm6335() {
            InitializeComponent();
            //铺满
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //初始化调用刷新事件，简化代码
            btnRefresh_Click(null, null);
            //设置窗口加载时按钮初始状态
            btnInsert_info.Enabled = false;
            btnUpdate_info.Enabled = true;
            btnDelete_info.Enabled = true;
        }

        private void btnInsert_info_Click(object sender, EventArgs e) {
            object sno = cmbStu_No.Text;

            //年龄赋值
            object age;
            if (string.IsNullOrWhiteSpace(tbStu_Age.Text)) {
                age = DBNull.Value;  //年龄为空
            } else {
                age = tbStu_Age.Text;
            }

            //姓名赋值
            object sname;
            if (string.IsNullOrWhiteSpace(tbStu_Name.Text)) {
                sname = DBNull.Value;  //姓名为空
            } else {
                sname = tbStu_Name.Text;
            }

            try {
                //获取性别单选值
                object sex;
                if (rbStu_Sex_female.Checked) {
                    sex = Convert.ToChar(rbStu_Sex_female.Text);
                } else if (rbStu_Sex_man.Checked) {
                    sex = Convert.ToChar(rbStu_Sex_man.Text);
                } else {
                    //否则为空
                    sex = DBNull.Value;
                }

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentConnectionString)) {
                    string strSql = "INSERT INTO xslist (SNo,SName,Sex,Age) VALUES(@sno,@sname,@sex,@age)";

                    connection.Open();
                    SqlCommand command = new SqlCommand(strSql, connection);
                    command.Parameters.Add(new SqlParameter("@sno", sno));
                    command.Parameters.Add(new SqlParameter("@sname", sname));
                    command.Parameters.Add(new SqlParameter("@sex", sex));
                    command.Parameters.Add(new SqlParameter("@age", age));
                    int res = command.ExecuteNonQuery();
                    MessageBox.Show($"新增 {res} 条数据");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_info_Click(object sender, EventArgs e) {
            object sno = cmbStu_No.Text;

            //年龄赋值
            object age;
            if (string.IsNullOrWhiteSpace(tbStu_Age.Text)) {
                age = DBNull.Value;  //年龄为空
            } else {
                age = tbStu_Age.Text;
            }

            //姓名赋值
            object sname;
            if (string.IsNullOrWhiteSpace(tbStu_Name.Text)) {
                sname = DBNull.Value;  //姓名为空
            } else {
                sname = tbStu_Name.Text;
            }

            try {
                //获取性别单选值
                object sex;
                if (rbStu_Sex_female.Checked) {
                    sex = Convert.ToChar(rbStu_Sex_female.Text);
                } else if (rbStu_Sex_man.Checked) {
                    sex = Convert.ToChar(rbStu_Sex_man.Text);
                } else {
                    sex = DBNull.Value;
                }

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentConnectionString)) {
                    string strSql = "UPDATE xslist SET " +
                        "SName=@sname,Sex=@sex,Age=@age " +
                        "WHERE SNo=@sno";

                    connection.Open();
                    SqlCommand command = new SqlCommand(strSql, connection);
                    command.Parameters.Add(new SqlParameter("@sno", sno));
                    command.Parameters.Add(new SqlParameter("@sname", sname));
                    command.Parameters.Add(new SqlParameter("@sex", sex));
                    command.Parameters.Add(new SqlParameter("@age", age));
                    int res = command.ExecuteNonQuery();
                    MessageBox.Show($"修改 {res} 条数据");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_info_Click(object sender, EventArgs e) {
            try {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentConnectionString)) {
                    string strSql = "DELETE FROM dbo.xslist WHERE SNo=@sno";

                    connection.Open();
                    SqlCommand command = new SqlCommand(strSql, connection);
                    command.Parameters.Add(new SqlParameter("@sno", cmbStu_No.Text));
                    int res = command.ExecuteNonQuery();
                    MessageBox.Show($"删除 {res} 条数据");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            string strSql = "SELECT * FROM dbo.xslist";

            //创建数据库连接对象
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentConnectionString)) {
                SqlCommand command = new SqlCommand(strSql, connection);
                //创建数据适配器对象
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                //创建数据缓存对象
                DataSet dataSet = new DataSet();
                //打开数据库连接
                connection.Open();
                //通过数据适配器填充数据库中的数据到缓存对象中
                dataAdapter.Fill(dataSet);
                //绑定数据源到数据表格视图
                //Tables[0]表示第一张表数据
                dataGridView1.DataSource = dataSet.Tables[0];

                //避免刷新数据时一并刷新下拉框列表默认显示值
                if (form == null) {
                    //绑定数据源到下拉列表
                    //显示学号列为列表值
                    cmbStu_No.DataSource = dataSet.Tables[0];
                    cmbStu_No.DisplayMember = "SNo";
                    form = new Form();
                }
            }
        }


        private void cmbStu_No_SelectedIndexChanged(object sender, EventArgs e) {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentConnectionString)) {
                string strSql = "SELECT * FROM xslist WHERE SNo=@sno";
                connection.Open();
                SqlCommand command = new SqlCommand(strSql, connection);
                command.Parameters.Add(new SqlParameter("@sno", cmbStu_No.Text));
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read()) {
                    btnInsert_info.Enabled = false;
                    btnUpdate_info.Enabled = true;
                    btnDelete_info.Enabled = true;
                } else {
                    btnInsert_info.Enabled = true;
                    btnUpdate_info.Enabled = false;
                    btnDelete_info.Enabled = false;
                }
            }
        }

        private void cmbStu_No_Leave(object sender, EventArgs e) {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentConnectionString)) {
                string strSql = "SELECT * FROM xslist WHERE SNo=@sno";
                connection.Open();
                SqlCommand command = new SqlCommand(strSql, connection);
                command.Parameters.Add(new SqlParameter("@sno", cmbStu_No.Text));
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read()) {
                    btnInsert_info.Enabled = false;
                    btnUpdate_info.Enabled = true;
                    btnDelete_info.Enabled = true;
                } else {
                    btnInsert_info.Enabled = true;
                    btnUpdate_info.Enabled = false;
                    btnDelete_info.Enabled = false;
                }
            }
        }

        private void cmbStu_No_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.StudentConnectionString)) {
                    string strSql = "SELECT * FROM xslist WHERE SNo=@sno";
                    connection.Open();
                    SqlCommand command = new SqlCommand(strSql, connection);
                    command.Parameters.Add(new SqlParameter("@sno", cmbStu_No.Text));
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.Read()) {
                        btnInsert_info.Enabled = false;
                        btnUpdate_info.Enabled = true;
                        btnDelete_info.Enabled = true;
                    } else {
                        btnInsert_info.Enabled = true;
                        btnUpdate_info.Enabled = false;
                        btnDelete_info.Enabled = false;
                    }
                }
            }
        }
    }
}
