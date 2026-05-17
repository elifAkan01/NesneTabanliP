using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSelamla_Click(object sender, EventArgs e)
        {
           if(tbAd.Text == "")
                MessageBox.Show("Merhaba, Yabancı!\r\nNasılsın, iyi misin?",
               "SELAM",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            else
                MessageBox.Show("Merhaba," + tbAd.Text + "!\r\nNasılsın, iyi misin?",
                    "SELAM",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
        }

        private void bKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSelamla_MouseEnter(object sender, EventArgs e)
        {
            bSelamla.Width += 40;
            bSelamla.Left -= 20;

        }

        private void bSelamla_MouseLeave(object sender, EventArgs e)
        {
            bSelamla.Width -= 40;
            bSelamla.Left += 20;

        }

        private void tbAd_Click(object sender, EventArgs e)
        {
            tbAd.Clear();
        }

        private void bKapat_MouseEnter(object sender, EventArgs e)
        {
            bKapat.Width += 40;
            bKapat.Left -= 20;
        }

        private void bKapat_MouseLeave(object sender, EventArgs e)
        {
            bKapat.Width -= 40;
            bKapat.Left += 20;
        }
    }
}
