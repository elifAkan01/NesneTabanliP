namespace BalıkYakala
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
            this.bKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bKapat
            // 
            this.bKapat.AutoSize = true;
            this.bKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKapat.Image = global::BalıkYakala.Properties.Resources.tURUNCU_balık;
            this.bKapat.Location = new System.Drawing.Point(62, 56);
            this.bKapat.Name = "bKapat";
            this.bKapat.Size = new System.Drawing.Size(454, 384);
            this.bKapat.TabIndex = 0;
            this.bKapat.Text = "button1";
            this.bKapat.UseVisualStyleBackColor = true;
            this.bKapat.Click += new System.EventHandler(this.bKapat_Click);
            this.bKapat.MouseEnter += new System.EventHandler(this.bKapat_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.bKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bKapat;
    }
}

