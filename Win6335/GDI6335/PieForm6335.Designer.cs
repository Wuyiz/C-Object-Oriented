namespace Win6335.GDI6335 {
    partial class PieForm6335 {
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
            this.SuspendLayout();
            // 
            // PieForm6335
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Font = new System.Drawing.Font("黑体", 13F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PieForm6335";
            this.Text = "饼图6335";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PieForm6335_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}