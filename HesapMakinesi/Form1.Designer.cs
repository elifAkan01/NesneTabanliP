namespace HesapMakinesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bTopla = new System.Windows.Forms.Button();
            this.tbSayı1 = new System.Windows.Forms.TextBox();
            this.tbSayı2 = new System.Windows.Forms.TextBox();
            this.bÇıkar = new System.Windows.Forms.Button();
            this.bÇarp = new System.Windows.Forms.Button();
            this.bBöl = new System.Windows.Forms.Button();
            this.tbIslem = new System.Windows.Forms.TextBox();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "&1. Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "&2. Sayı";
            // 
            // bTopla
            // 
            this.bTopla.Location = new System.Drawing.Point(219, 56);
            this.bTopla.Name = "bTopla";
            this.bTopla.Size = new System.Drawing.Size(103, 35);
            this.bTopla.TabIndex = 2;
            this.bTopla.Text = "&Toplam";
            this.bTopla.UseVisualStyleBackColor = true;
            this.bTopla.Click += new System.EventHandler(this.bTopla_Click);
            // 
            // tbSayı1
            // 
            this.tbSayı1.Location = new System.Drawing.Point(34, 62);
            this.tbSayı1.Multiline = true;
            this.tbSayı1.Name = "tbSayı1";
            this.tbSayı1.Size = new System.Drawing.Size(179, 29);
            this.tbSayı1.TabIndex = 3;
            // 
            // tbSayı2
            // 
            this.tbSayı2.Location = new System.Drawing.Point(328, 62);
            this.tbSayı2.Multiline = true;
            this.tbSayı2.Name = "tbSayı2";
            this.tbSayı2.Size = new System.Drawing.Size(179, 29);
            this.tbSayı2.TabIndex = 4;
            // 
            // bÇıkar
            // 
            this.bÇıkar.Location = new System.Drawing.Point(219, 112);
            this.bÇıkar.Name = "bÇıkar";
            this.bÇıkar.Size = new System.Drawing.Size(103, 33);
            this.bÇıkar.TabIndex = 5;
            this.bÇıkar.Text = "&Çıkar";
            this.bÇıkar.UseVisualStyleBackColor = true;
            this.bÇıkar.Click += new System.EventHandler(this.bÇıkar_Click);
            // 
            // bÇarp
            // 
            this.bÇarp.Location = new System.Drawing.Point(219, 175);
            this.bÇarp.Name = "bÇarp";
            this.bÇarp.Size = new System.Drawing.Size(103, 36);
            this.bÇarp.TabIndex = 6;
            this.bÇarp.Text = "Çar&p";
            this.bÇarp.UseVisualStyleBackColor = true;
            this.bÇarp.Click += new System.EventHandler(this.bÇarp_Click);
            // 
            // bBöl
            // 
            this.bBöl.Location = new System.Drawing.Point(219, 238);
            this.bBöl.Name = "bBöl";
            this.bBöl.Size = new System.Drawing.Size(103, 37);
            this.bBöl.TabIndex = 7;
            this.bBöl.Text = "&Böl";
            this.bBöl.UseVisualStyleBackColor = true;
            this.bBöl.Click += new System.EventHandler(this.bBöl_Click);
            // 
            // tbIslem
            // 
            this.tbIslem.Location = new System.Drawing.Point(111, 293);
            this.tbIslem.Multiline = true;
            this.tbIslem.Name = "tbIslem";
            this.tbIslem.Size = new System.Drawing.Size(396, 45);
            this.tbIslem.TabIndex = 8;
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(111, 344);
            this.tbSonuc.Multiline = true;
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.Size = new System.Drawing.Size(396, 45);
            this.tbSonuc.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "&İşlem :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "&Sonuç :";
            // 
            // bKapat
            // 
            this.bKapat.Location = new System.Drawing.Point(219, 409);
            this.bKapat.Name = "bKapat";
            this.bKapat.Size = new System.Drawing.Size(97, 37);
            this.bKapat.TabIndex = 12;
            this.bKapat.Text = "Kapa&t";
            this.bKapat.UseVisualStyleBackColor = true;
            this.bKapat.Click += new System.EventHandler(this.bKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 458);
            this.Controls.Add(this.bKapat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.tbIslem);
            this.Controls.Add(this.bBöl);
            this.Controls.Add(this.bÇarp);
            this.Controls.Add(this.bÇıkar);
            this.Controls.Add(this.tbSayı2);
            this.Controls.Add(this.tbSayı1);
            this.Controls.Add(this.bTopla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bTopla;
        private System.Windows.Forms.TextBox tbSayı1;
        private System.Windows.Forms.TextBox tbSayı2;
        private System.Windows.Forms.Button bÇıkar;
        private System.Windows.Forms.Button bÇarp;
        private System.Windows.Forms.Button bBöl;
        private System.Windows.Forms.TextBox tbIslem;
        private System.Windows.Forms.TextBox tbSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bKapat;
    }
}

