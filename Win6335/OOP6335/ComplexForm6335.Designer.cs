namespace Win6335.OOP6335 {
    partial class ComplexForm6335 {
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
            this.tbRfigure1 = new System.Windows.Forms.TextBox();
            this.tbURfigure1 = new System.Windows.Forms.TextBox();
            this.tbURfigure2 = new System.Windows.Forms.TextBox();
            this.tbRfigure2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGt = new System.Windows.Forms.RadioButton();
            this.rbLt = new System.Windows.Forms.RadioButton();
            this.rbNeq = new System.Windows.Forms.RadioButton();
            this.rbEq = new System.Windows.Forms.RadioButton();
            this.rbSub = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRfigure1
            // 
            this.tbRfigure1.Location = new System.Drawing.Point(117, 61);
            this.tbRfigure1.Name = "tbRfigure1";
            this.tbRfigure1.Size = new System.Drawing.Size(105, 32);
            this.tbRfigure1.TabIndex = 0;
            // 
            // tbURfigure1
            // 
            this.tbURfigure1.Location = new System.Drawing.Point(241, 61);
            this.tbURfigure1.Name = "tbURfigure1";
            this.tbURfigure1.Size = new System.Drawing.Size(105, 32);
            this.tbURfigure1.TabIndex = 1;
            // 
            // tbURfigure2
            // 
            this.tbURfigure2.Location = new System.Drawing.Point(643, 61);
            this.tbURfigure2.Name = "tbURfigure2";
            this.tbURfigure2.Size = new System.Drawing.Size(105, 32);
            this.tbURfigure2.TabIndex = 3;
            // 
            // tbRfigure2
            // 
            this.tbRfigure2.Location = new System.Drawing.Point(519, 61);
            this.tbRfigure2.Name = "tbRfigure2";
            this.tbRfigure2.Size = new System.Drawing.Size(105, 32);
            this.tbRfigure2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "复数1：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "复数2：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "i";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(754, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "i";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "实部       虚部";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "实部       虚部";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGt);
            this.groupBox1.Controls.Add(this.rbLt);
            this.groupBox1.Controls.Add(this.rbNeq);
            this.groupBox1.Controls.Add(this.rbEq);
            this.groupBox1.Controls.Add(this.rbSub);
            this.groupBox1.Controls.Add(this.rbAdd);
            this.groupBox1.Location = new System.Drawing.Point(28, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择运算符：";
            // 
            // rbGt
            // 
            this.rbGt.AutoSize = true;
            this.rbGt.Location = new System.Drawing.Point(650, 31);
            this.rbGt.Name = "rbGt";
            this.rbGt.Size = new System.Drawing.Size(42, 26);
            this.rbGt.TabIndex = 5;
            this.rbGt.TabStop = true;
            this.rbGt.Text = ">";
            this.rbGt.UseVisualStyleBackColor = true;
            this.rbGt.Click += new System.EventHandler(this.rbGt_Click);
            // 
            // rbLt
            // 
            this.rbLt.AutoSize = true;
            this.rbLt.Location = new System.Drawing.Point(531, 31);
            this.rbLt.Name = "rbLt";
            this.rbLt.Size = new System.Drawing.Size(42, 26);
            this.rbLt.TabIndex = 4;
            this.rbLt.TabStop = true;
            this.rbLt.Text = "<";
            this.rbLt.UseVisualStyleBackColor = true;
            this.rbLt.Click += new System.EventHandler(this.rbLt_Click);
            // 
            // rbNeq
            // 
            this.rbNeq.AutoSize = true;
            this.rbNeq.Location = new System.Drawing.Point(402, 31);
            this.rbNeq.Name = "rbNeq";
            this.rbNeq.Size = new System.Drawing.Size(53, 26);
            this.rbNeq.TabIndex = 3;
            this.rbNeq.TabStop = true;
            this.rbNeq.Text = "!=";
            this.rbNeq.UseVisualStyleBackColor = true;
            this.rbNeq.Click += new System.EventHandler(this.rbNeq_Click);
            // 
            // rbEq
            // 
            this.rbEq.AutoSize = true;
            this.rbEq.Location = new System.Drawing.Point(276, 31);
            this.rbEq.Name = "rbEq";
            this.rbEq.Size = new System.Drawing.Size(53, 26);
            this.rbEq.TabIndex = 2;
            this.rbEq.TabStop = true;
            this.rbEq.Text = "==";
            this.rbEq.UseVisualStyleBackColor = true;
            this.rbEq.Click += new System.EventHandler(this.rbEq_Click);
            // 
            // rbSub
            // 
            this.rbSub.AutoSize = true;
            this.rbSub.Location = new System.Drawing.Point(152, 31);
            this.rbSub.Name = "rbSub";
            this.rbSub.Size = new System.Drawing.Size(42, 26);
            this.rbSub.TabIndex = 1;
            this.rbSub.TabStop = true;
            this.rbSub.Text = "-";
            this.rbSub.UseVisualStyleBackColor = true;
            this.rbSub.Click += new System.EventHandler(this.rbSub_Click);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(41, 31);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(42, 26);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "+";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.Click += new System.EventHandler(this.rbAdd_Click);
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbResult.Font = new System.Drawing.Font("隶书", 20F);
            this.tbResult.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tbResult.Location = new System.Drawing.Point(28, 234);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(471, 46);
            this.tbResult.TabIndex = 11;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComplexForm6335
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 334);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbURfigure2);
            this.Controls.Add(this.tbRfigure2);
            this.Controls.Add(this.tbURfigure1);
            this.Controls.Add(this.tbRfigure1);
            this.Font = new System.Drawing.Font("隶书", 13F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComplexForm6335";
            this.Text = "复数的运算6335";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRfigure1;
        private System.Windows.Forms.TextBox tbURfigure1;
        private System.Windows.Forms.TextBox tbURfigure2;
        private System.Windows.Forms.TextBox tbRfigure2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGt;
        private System.Windows.Forms.RadioButton rbLt;
        private System.Windows.Forms.RadioButton rbNeq;
        private System.Windows.Forms.RadioButton rbEq;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.TextBox tbResult;
    }
}