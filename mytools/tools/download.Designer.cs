namespace mytools.tools {
    partial class download {
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
            this.btnTrans = new System.Windows.Forms.Button();
            this.tbLink1 = new System.Windows.Forms.TextBox();
            this.tbLink2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(88, 332);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(98, 46);
            this.btnTrans.TabIndex = 2;
            this.btnTrans.Text = "转换";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // tbLink1
            // 
            this.tbLink1.Location = new System.Drawing.Point(88, 73);
            this.tbLink1.Multiline = true;
            this.tbLink1.Name = "tbLink1";
            this.tbLink1.Size = new System.Drawing.Size(709, 85);
            this.tbLink1.TabIndex = 3;
            // 
            // tbLink2
            // 
            this.tbLink2.Location = new System.Drawing.Point(88, 183);
            this.tbLink2.Multiline = true;
            this.tbLink2.Name = "tbLink2";
            this.tbLink2.Size = new System.Drawing.Size(709, 85);
            this.tbLink2.TabIndex = 4;
            // 
            // download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 533);
            this.Controls.Add(this.tbLink2);
            this.Controls.Add(this.tbLink1);
            this.Controls.Add(this.btnTrans);
            this.Font = new System.Drawing.Font("黑体", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "download";
            this.Text = "download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.TextBox tbLink1;
        private System.Windows.Forms.TextBox tbLink2;
    }
}