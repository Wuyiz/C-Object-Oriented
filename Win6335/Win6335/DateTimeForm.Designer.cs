namespace Win6335.Win6335 {
    partial class DateTimeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
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
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSpan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWeek
            // 
            this.btnWeek.Font = new System.Drawing.Font("宋体", 12F);
            this.btnWeek.Location = new System.Drawing.Point(77, 196);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(106, 40);
            this.btnWeek.TabIndex = 7;
            this.btnWeek.Text = "计算星期";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDay
            // 
            this.btnDay.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDay.Location = new System.Drawing.Point(77, 287);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(106, 40);
            this.btnDay.TabIndex = 9;
            this.btnDay.Text = "计算";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("宋体", 13F);
            this.txtYear.Location = new System.Drawing.Point(236, 100);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(80, 32);
            this.txtYear.TabIndex = 1;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypressed);
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("宋体", 13F);
            this.txtMonth.Location = new System.Drawing.Point(365, 100);
            this.txtMonth.MaxLength = 2;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(40, 32);
            this.txtMonth.TabIndex = 3;
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypressed);
            // 
            // txtDay
            // 
            this.txtDay.Font = new System.Drawing.Font("宋体", 13F);
            this.txtDay.Location = new System.Drawing.Point(454, 100);
            this.txtDay.MaxLength = 2;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(40, 32);
            this.txtDay.TabIndex = 5;
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypressed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(72, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(322, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "年";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(411, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "月";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(500, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "日";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Font = new System.Drawing.Font("宋体", 15F);
            this.lblWeek.Location = new System.Drawing.Point(209, 202);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(51, 25);
            this.lblWeek.TabIndex = 8;
            this.lblWeek.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(209, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "显示";
            // 
            // txtSpan
            // 
            this.txtSpan.Font = new System.Drawing.Font("宋体", 13F);
            this.txtSpan.Location = new System.Drawing.Point(277, 290);
            this.txtSpan.MaxLength = 4;
            this.txtSpan.Name = "txtSpan";
            this.txtSpan.Size = new System.Drawing.Size(60, 32);
            this.txtSpan.TabIndex = 11;
            this.txtSpan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypressed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F);
            this.label7.Location = new System.Drawing.Point(343, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "天后的日期：";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("宋体", 15F);
            this.lblDate.Location = new System.Drawing.Point(493, 296);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 25);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "...";
            // 
            // DateTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSpan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnWeek);
            this.Name = "DateTimeForm";
            this.Text = "DateTimeForm6335";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.DateTimeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSpan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDate;
    }
}