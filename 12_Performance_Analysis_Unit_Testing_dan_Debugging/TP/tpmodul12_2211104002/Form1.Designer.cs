namespace tpmodul12_2211104002
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Label lblHasil;

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(33, 36);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 22);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "  ";
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(33, 66);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(100, 23);
            this.btnCek.TabIndex = 1;
            this.btnCek.Text = "  ";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(30, 100);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(0, 16);
            this.lblHasil.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(536, 331);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.lblHasil);
            this.Name = "Form1";
            this.Text = "Tugas Modul 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
