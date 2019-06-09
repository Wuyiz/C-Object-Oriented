namespace Win6335.FileIO6335 {
    partial class FileSystemWatcherForm6335 {
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
            this.btnSelect_file = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.cklbAction = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFilterType = new System.Windows.Forms.TextBox();
            this.btnOn_Off = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "要监视的路径：";
            // 
            // btnSelect_file
            // 
            this.btnSelect_file.Location = new System.Drawing.Point(470, 2);
            this.btnSelect_file.Name = "btnSelect_file";
            this.btnSelect_file.Size = new System.Drawing.Size(83, 42);
            this.btnSelect_file.TabIndex = 1;
            this.btnSelect_file.Text = "选择";
            this.btnSelect_file.UseVisualStyleBackColor = true;
            this.btnSelect_file.Click += new System.EventHandler(this.btnSelect_file_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(182, 9);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(282, 32);
            this.tbPath.TabIndex = 2;
            // 
            // cklbAction
            // 
            this.cklbAction.FormattingEnabled = true;
            this.cklbAction.Location = new System.Drawing.Point(619, 12);
            this.cklbAction.Name = "cklbAction";
            this.cklbAction.Size = new System.Drawing.Size(202, 166);
            this.cklbAction.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "要监视的文件：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(588, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 166);
            this.label3.TabIndex = 0;
            this.label3.Text = "要监视的操作";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFilterType
            // 
            this.tbFilterType.Location = new System.Drawing.Point(182, 62);
            this.tbFilterType.Name = "tbFilterType";
            this.tbFilterType.Size = new System.Drawing.Size(159, 32);
            this.tbFilterType.TabIndex = 2;
            // 
            // btnOn_Off
            // 
            this.btnOn_Off.Location = new System.Drawing.Point(44, 157);
            this.btnOn_Off.Name = "btnOn_Off";
            this.btnOn_Off.Size = new System.Drawing.Size(132, 42);
            this.btnOn_Off.TabIndex = 1;
            this.btnOn_Off.Text = "开始监视";
            this.btnOn_Off.UseVisualStyleBackColor = true;
            this.btnOn_Off.Click += new System.EventHandler(this.btnOn_Off_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(421, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 42);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空显示";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(12, 205);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(809, 234);
            this.tbDisplay.TabIndex = 2;
            // 
            // FileSystemWatcherForm6335
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 440);
            this.Controls.Add(this.cklbAction);
            this.Controls.Add(this.tbFilterType);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOn_Off);
            this.Controls.Add(this.btnSelect_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("隶书", 13F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileSystemWatcherForm6335";
            this.Text = "文件系统监视器6335";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect_file;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.CheckedListBox cklbAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFilterType;
        private System.Windows.Forms.Button btnOn_Off;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}