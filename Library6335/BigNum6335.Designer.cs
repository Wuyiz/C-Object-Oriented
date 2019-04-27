namespace Library6335 {
    partial class BigNum6335 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.btnTrans = new System.Windows.Forms.Button();
            this.lbUpper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMoney
            // 
            this.tbMoney.Font = new System.Drawing.Font("隶书", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMoney.Location = new System.Drawing.Point(12, 46);
            this.tbMoney.MaxLength = 1000;
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(426, 45);
            this.tbMoney.TabIndex = 0;
            // 
            // btnTrans
            // 
            this.btnTrans.Font = new System.Drawing.Font("隶书", 20F);
            this.btnTrans.Location = new System.Drawing.Point(474, 32);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(160, 67);
            this.btnTrans.TabIndex = 1;
            this.btnTrans.Text = "转换";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // lbUpper
            // 
            this.lbUpper.AutoSize = true;
            this.lbUpper.Font = new System.Drawing.Font("隶书", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUpper.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUpper.Location = new System.Drawing.Point(12, 129);
            this.lbUpper.Name = "lbUpper";
            this.lbUpper.Size = new System.Drawing.Size(66, 33);
            this.lbUpper.TabIndex = 2;
            this.lbUpper.Text = "...";
            // 
            // BigNum6335
            // 
            this.AcceptButton = this.btnTrans;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 217);
            this.Controls.Add(this.lbUpper);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.tbMoney);
            this.Name = "BigNum6335";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Label lbUpper;
    }
}

