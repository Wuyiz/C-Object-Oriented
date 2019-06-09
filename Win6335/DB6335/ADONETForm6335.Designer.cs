namespace Win6335.DB6335 {
    partial class ADONETForm6335 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStu_No = new System.Windows.Forms.ComboBox();
            this.btnInsert_info = new System.Windows.Forms.Button();
            this.tbStu_Name = new System.Windows.Forms.TextBox();
            this.tbStu_Age = new System.Windows.Forms.TextBox();
            this.rbStu_Sex_man = new System.Windows.Forms.RadioButton();
            this.rbStu_Sex_female = new System.Windows.Forms.RadioButton();
            this.btnUpdate_info = new System.Windows.Forms.Button();
            this.btnDelete_info = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "年龄：";
            // 
            // cmbStu_No
            // 
            this.cmbStu_No.FormattingEnabled = true;
            this.cmbStu_No.Location = new System.Drawing.Point(94, 29);
            this.cmbStu_No.Name = "cmbStu_No";
            this.cmbStu_No.Size = new System.Drawing.Size(226, 30);
            this.cmbStu_No.TabIndex = 1;
            this.cmbStu_No.SelectedIndexChanged += new System.EventHandler(this.cmbStu_No_SelectedIndexChanged);
            this.cmbStu_No.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStu_No_KeyDown);
            this.cmbStu_No.Leave += new System.EventHandler(this.cmbStu_No_Leave);
            // 
            // btnInsert_info
            // 
            this.btnInsert_info.Location = new System.Drawing.Point(393, 6);
            this.btnInsert_info.Name = "btnInsert_info";
            this.btnInsert_info.Size = new System.Drawing.Size(156, 50);
            this.btnInsert_info.TabIndex = 2;
            this.btnInsert_info.Text = "增加新学生";
            this.btnInsert_info.UseVisualStyleBackColor = true;
            this.btnInsert_info.Click += new System.EventHandler(this.btnInsert_info_Click);
            // 
            // tbStu_Name
            // 
            this.tbStu_Name.Location = new System.Drawing.Point(94, 75);
            this.tbStu_Name.Name = "tbStu_Name";
            this.tbStu_Name.Size = new System.Drawing.Size(226, 32);
            this.tbStu_Name.TabIndex = 3;
            // 
            // tbStu_Age
            // 
            this.tbStu_Age.Location = new System.Drawing.Point(94, 173);
            this.tbStu_Age.Name = "tbStu_Age";
            this.tbStu_Age.Size = new System.Drawing.Size(103, 32);
            this.tbStu_Age.TabIndex = 3;
            // 
            // rbStu_Sex_man
            // 
            this.rbStu_Sex_man.AutoSize = true;
            this.rbStu_Sex_man.Location = new System.Drawing.Point(94, 129);
            this.rbStu_Sex_man.Name = "rbStu_Sex_man";
            this.rbStu_Sex_man.Size = new System.Drawing.Size(53, 26);
            this.rbStu_Sex_man.TabIndex = 4;
            this.rbStu_Sex_man.TabStop = true;
            this.rbStu_Sex_man.Text = "男";
            this.rbStu_Sex_man.UseVisualStyleBackColor = true;
            // 
            // rbStu_Sex_female
            // 
            this.rbStu_Sex_female.AutoSize = true;
            this.rbStu_Sex_female.Location = new System.Drawing.Point(170, 129);
            this.rbStu_Sex_female.Name = "rbStu_Sex_female";
            this.rbStu_Sex_female.Size = new System.Drawing.Size(53, 26);
            this.rbStu_Sex_female.TabIndex = 4;
            this.rbStu_Sex_female.TabStop = true;
            this.rbStu_Sex_female.Text = "女";
            this.rbStu_Sex_female.UseVisualStyleBackColor = true;
            // 
            // btnUpdate_info
            // 
            this.btnUpdate_info.Location = new System.Drawing.Point(393, 81);
            this.btnUpdate_info.Name = "btnUpdate_info";
            this.btnUpdate_info.Size = new System.Drawing.Size(156, 50);
            this.btnUpdate_info.TabIndex = 2;
            this.btnUpdate_info.Text = "修改学生信息";
            this.btnUpdate_info.UseVisualStyleBackColor = true;
            this.btnUpdate_info.Click += new System.EventHandler(this.btnUpdate_info_Click);
            // 
            // btnDelete_info
            // 
            this.btnDelete_info.Location = new System.Drawing.Point(393, 155);
            this.btnDelete_info.Name = "btnDelete_info";
            this.btnDelete_info.Size = new System.Drawing.Size(156, 50);
            this.btnDelete_info.TabIndex = 2;
            this.btnDelete_info.Text = "删除";
            this.btnDelete_info.UseVisualStyleBackColor = true;
            this.btnDelete_info.Click += new System.EventHandler(this.btnDelete_info_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(553, 336);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(206, 553);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(156, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ADONETForm6335
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbStu_Sex_female);
            this.Controls.Add(this.rbStu_Sex_man);
            this.Controls.Add(this.tbStu_Age);
            this.Controls.Add(this.tbStu_Name);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete_info);
            this.Controls.Add(this.btnUpdate_info);
            this.Controls.Add(this.btnInsert_info);
            this.Controls.Add(this.cmbStu_No);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("隶书", 13F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ADONETForm6335";
            this.Text = "ADO.NET的使用6335";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStu_No;
        private System.Windows.Forms.Button btnInsert_info;
        private System.Windows.Forms.TextBox tbStu_Name;
        private System.Windows.Forms.TextBox tbStu_Age;
        private System.Windows.Forms.RadioButton rbStu_Sex_man;
        private System.Windows.Forms.RadioButton rbStu_Sex_female;
        private System.Windows.Forms.Button btnUpdate_info;
        private System.Windows.Forms.Button btnDelete_info;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
    }
}