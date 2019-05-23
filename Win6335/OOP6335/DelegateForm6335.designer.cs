namespace Win6335.OOP6335 {
    partial class DelegateForm6335 {
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSource = new System.Windows.Forms.RadioButton();
            this.rbScore = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.btnList_li = new System.Windows.Forms.Button();
            this.btn400 = new System.Windows.Forms.Button();
            this.btnXiamen_stu = new System.Windows.Forms.Button();
            this.lINQForm6335BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lINQForm6335BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMin_Score = new System.Windows.Forms.RadioButton();
            this.rbMax_Score = new System.Windows.Forms.RadioButton();
            this.rbAverge_Score = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lINQForm6335BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINQForm6335BindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(678, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("隶书", 13F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(336, 295);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 200);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSource);
            this.groupBox1.Controls.Add(this.rbScore);
            this.groupBox1.Controls.Add(this.rbName);
            this.groupBox1.Controls.Add(this.rbID);
            this.groupBox1.Location = new System.Drawing.Point(8, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "排序";
            // 
            // rbSource
            // 
            this.rbSource.AutoSize = true;
            this.rbSource.Location = new System.Drawing.Point(210, 32);
            this.rbSource.Name = "rbSource";
            this.rbSource.Size = new System.Drawing.Size(97, 26);
            this.rbSource.TabIndex = 3;
            this.rbSource.TabStop = true;
            this.rbSource.Text = "生源地";
            this.rbSource.UseVisualStyleBackColor = true;
            this.rbSource.CheckedChanged += new System.EventHandler(this.rbSource_CheckedChanged);
            // 
            // rbScore
            // 
            this.rbScore.AutoSize = true;
            this.rbScore.Location = new System.Drawing.Point(142, 32);
            this.rbScore.Name = "rbScore";
            this.rbScore.Size = new System.Drawing.Size(75, 26);
            this.rbScore.TabIndex = 2;
            this.rbScore.TabStop = true;
            this.rbScore.Text = "成绩";
            this.rbScore.UseVisualStyleBackColor = true;
            this.rbScore.CheckedChanged += new System.EventHandler(this.rbScore_CheckedChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(74, 32);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(75, 26);
            this.rbName.TabIndex = 1;
            this.rbName.TabStop = true;
            this.rbName.Text = "姓名";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(6, 32);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(75, 26);
            this.rbID.TabIndex = 0;
            this.rbID.TabStop = true;
            this.rbID.Text = "学号";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // btnList_li
            // 
            this.btnList_li.Location = new System.Drawing.Point(6, 355);
            this.btnList_li.Name = "btnList_li";
            this.btnList_li.Size = new System.Drawing.Size(131, 34);
            this.btnList_li.TabIndex = 4;
            this.btnList_li.Text = "姓李的名单";
            this.btnList_li.UseVisualStyleBackColor = true;
            this.btnList_li.Click += new System.EventHandler(this.btnList_li_Click);
            // 
            // btn400
            // 
            this.btn400.Location = new System.Drawing.Point(7, 395);
            this.btn400.Name = "btn400";
            this.btn400.Size = new System.Drawing.Size(186, 34);
            this.btn400.TabIndex = 5;
            this.btn400.Text = "400分以上的名单";
            this.btn400.UseVisualStyleBackColor = true;
            this.btn400.Click += new System.EventHandler(this.btn400_Click);
            // 
            // btnXiamen_stu
            // 
            this.btnXiamen_stu.Location = new System.Drawing.Point(143, 355);
            this.btnXiamen_stu.Name = "btnXiamen_stu";
            this.btnXiamen_stu.Size = new System.Drawing.Size(186, 34);
            this.btnXiamen_stu.TabIndex = 6;
            this.btnXiamen_stu.Text = "来自厦门的学生";
            this.btnXiamen_stu.UseVisualStyleBackColor = true;
            this.btnXiamen_stu.Click += new System.EventHandler(this.btnXiamen_stu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMin_Score);
            this.groupBox2.Controls.Add(this.rbMax_Score);
            this.groupBox2.Controls.Add(this.rbAverge_Score);
            this.groupBox2.Location = new System.Drawing.Point(8, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 60);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "统计成绩";
            // 
            // rbMin_Score
            // 
            this.rbMin_Score.AutoSize = true;
            this.rbMin_Score.Location = new System.Drawing.Point(228, 25);
            this.rbMin_Score.Name = "rbMin_Score";
            this.rbMin_Score.Size = new System.Drawing.Size(97, 26);
            this.rbMin_Score.TabIndex = 2;
            this.rbMin_Score.TabStop = true;
            this.rbMin_Score.Text = "最低分";
            this.rbMin_Score.UseVisualStyleBackColor = true;
            this.rbMin_Score.Click += new System.EventHandler(this.rbMin_Score_Click);
            // 
            // rbMax_Score
            // 
            this.rbMax_Score.AutoSize = true;
            this.rbMax_Score.Location = new System.Drawing.Point(125, 25);
            this.rbMax_Score.Name = "rbMax_Score";
            this.rbMax_Score.Size = new System.Drawing.Size(97, 26);
            this.rbMax_Score.TabIndex = 1;
            this.rbMax_Score.TabStop = true;
            this.rbMax_Score.Text = "最高分";
            this.rbMax_Score.UseVisualStyleBackColor = true;
            this.rbMax_Score.Click += new System.EventHandler(this.rbMax_Score_Click);
            // 
            // rbAverge_Score
            // 
            this.rbAverge_Score.AutoSize = true;
            this.rbAverge_Score.Location = new System.Drawing.Point(6, 25);
            this.rbAverge_Score.Name = "rbAverge_Score";
            this.rbAverge_Score.Size = new System.Drawing.Size(119, 26);
            this.rbAverge_Score.TabIndex = 0;
            this.rbAverge_Score.TabStop = true;
            this.rbAverge_Score.Text = "平均成绩";
            this.rbAverge_Score.UseVisualStyleBackColor = true;
            this.rbAverge_Score.Click += new System.EventHandler(this.rbAverge_Score_Click);
            // 
            // DelegateForm6335
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXiamen_stu);
            this.Controls.Add(this.btn400);
            this.Controls.Add(this.btnList_li);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("隶书", 13F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DelegateForm6335";
            this.Text = "委托在集合中的应用6335";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lINQForm6335BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINQForm6335BindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSource;
        private System.Windows.Forms.RadioButton rbScore;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.Button btnList_li;
        private System.Windows.Forms.Button btn400;
        private System.Windows.Forms.Button btnXiamen_stu;
        private System.Windows.Forms.BindingSource lINQForm6335BindingSource;
        private System.Windows.Forms.BindingSource lINQForm6335BindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMin_Score;
        private System.Windows.Forms.RadioButton rbMax_Score;
        private System.Windows.Forms.RadioButton rbAverge_Score;
    }
}