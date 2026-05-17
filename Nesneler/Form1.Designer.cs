namespace Nesneler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            this.tbAd = new System.Windows.Forms.TextBox();
            this.bSelamla = new System.Windows.Forms.Button();
            this.bKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(120, 57);
            this.tbAd.Multiline = true;
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(165, 24);
            this.tbAd.TabIndex = 0;
            this.tbAd.Text = "İsminizi giriniz.";
            this.tbAd.Click += new System.EventHandler(this.tbAd_Click);
            // 
            // bSelamla
            // 
            this.bSelamla.Location = new System.Drawing.Point(120, 109);
            this.bSelamla.Name = "bSelamla";
            this.bSelamla.Size = new System.Drawing.Size(75, 30);
            this.bSelamla.TabIndex = 1;
            this.bSelamla.Text = "&Selamla";
            this.bSelamla.UseVisualStyleBackColor = true;
            this.bSelamla.Click += new System.EventHandler(this.bSelamla_Click);
            this.bSelamla.MouseEnter += new System.EventHandler(this.bSelamla_MouseEnter);
            this.bSelamla.MouseLeave += new System.EventHandler(this.bSelamla_MouseLeave);
            // 
            // bKapat
            // 
            this.bKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bKapat.Location = new System.Drawing.Point(120, 145);
            this.bKapat.Name = "bKapat";
            this.bKapat.Size = new System.Drawing.Size(75, 34);
            this.bKapat.TabIndex = 2;
            this.bKapat.Text = "&Kapat";
            this.bKapat.UseVisualStyleBackColor = true;
            this.bKapat.Click += new System.EventHandler(this.bKapat_Click);
            this.bKapat.MouseEnter += new System.EventHandler(this.bKapat_MouseEnter);
            this.bKapat.MouseLeave += new System.EventHandler(this.bKapat_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adınız:";
            // 
            // Form1
            // 
            this.AcceptButton = this.bSelamla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bKapat;
            this.ClientSize = new System.Drawing.Size(355, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bKapat);
            this.Controls.Add(this.bSelamla);
            this.Controls.Add(this.tbAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Button bSelamla;
        private System.Windows.Forms.Button bKapat;
        private System.Windows.Forms.Label label1;
    }
}

