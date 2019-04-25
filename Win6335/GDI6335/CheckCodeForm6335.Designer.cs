namespace Win6335.GDI6335 {
    partial class CheckCodeForm6335 {
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
            this.picbVerify = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbVerify)).BeginInit();
            this.SuspendLayout();
            // 
            // picbVerify
            // 
            this.picbVerify.Location = new System.Drawing.Point(12, 12);
            this.picbVerify.Name = "picbVerify";
            this.picbVerify.Size = new System.Drawing.Size(220, 103);
            this.picbVerify.TabIndex = 0;
            this.picbVerify.TabStop = false;
            this.picbVerify.Click += new System.EventHandler(this.picbVerify_Click);
            // 
            // CheckCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(584, 272);
            this.Controls.Add(this.picbVerify);
            this.Name = "CheckCodeForm";
            this.Text = "验证码6335";
            ((System.ComponentModel.ISupportInitialize)(this.picbVerify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbVerify;
    }
}