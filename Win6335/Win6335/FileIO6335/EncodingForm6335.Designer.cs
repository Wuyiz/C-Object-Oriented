namespace Win6335.Win6335.FileIO6335 {
    partial class EncodingForm6335 {
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFile_name = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文本：";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 34);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(595, 165);
            this.tbInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "编码方案：";
            // 
            // tbFile_name
            // 
            this.tbFile_name.Location = new System.Drawing.Point(102, 219);
            this.tbFile_name.Name = "tbFile_name";
            this.tbFile_name.Size = new System.Drawing.Size(375, 32);
            this.tbFile_name.TabIndex = 2;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(483, 218);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(124, 33);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "写入文件";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(483, 257);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(124, 33);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "读文件";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(102, 259);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(375, 30);
            this.cmbEncoding.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "文件内容：";
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(12, 334);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(595, 165);
            this.tbDisplay.TabIndex = 1;
            // 
            // EncodingForm6335
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 509);
            this.Controls.Add(this.cmbEncoding);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.tbFile_name);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("隶书", 13F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EncodingForm6335";
            this.Text = "字符的编码与解码6335";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFile_name;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}