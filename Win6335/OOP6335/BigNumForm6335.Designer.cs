namespace Win6335.OOP6335 {
    partial class BigNumForm6335 {
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
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.btnTrans = new System.Windows.Forms.Button();
            this.lbUpper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMoney
            // 
            this.tbMoney.Font = new System.Drawing.Font("隶书", 20F);
            this.tbMoney.Location = new System.Drawing.Point(12, 51);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(439, 46);
            this.tbMoney.TabIndex = 0;
            // 
            // btnTrans
            // 
            this.btnTrans.Font = new System.Drawing.Font("隶书", 20F);
            this.btnTrans.Location = new System.Drawing.Point(494, 40);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(160, 60);
            this.btnTrans.TabIndex = 1;
            this.btnTrans.Text = "转换";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // lbUpper
            // 
            this.lbUpper.AutoSize = true;
            this.lbUpper.Font = new System.Drawing.Font("隶书", 20F);
            this.lbUpper.Location = new System.Drawing.Point(12, 128);
            this.lbUpper.Name = "lbUpper";
            this.lbUpper.Size = new System.Drawing.Size(66, 34);
            this.lbUpper.TabIndex = 2;
            this.lbUpper.Text = "...";
            // 
            // BigNumForm6335
            // 
            this.AcceptButton = this.btnTrans;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 204);
            this.Controls.Add(this.lbUpper);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.tbMoney);
            this.Name = "BigNumForm6335";
            this.Text = "发票上的大写金额6335";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Label lbUpper;
    }
}