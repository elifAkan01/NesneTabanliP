using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bTopla_Click(object sender, EventArgs e)
        {
            double sonuc;
            tbIslem.Text = tbSayı1.Text + " + " + tbSayı2.Text;
            sonuc = Convert.ToDouble(tbSayı1.Text) +
                Convert.ToDouble(tbSayı2.Text);
            tbSonuc.Text = sonuc.ToString();
        }

        private void bÇıkar_Click(object sender, EventArgs e)
        {
            double sonuc;
            tbIslem.Text = tbSayı1.Text + " - " + tbSayı2.Text;
            sonuc = Convert.ToDouble(tbSayı1.Text) -
                Convert.ToDouble(tbSayı2.Text);
            tbSonuc.Text = sonuc.ToString();
        }

        private void bÇarp_Click(object sender, EventArgs e)
        {
            double sonuc;
            tbIslem.Text = tbSayı1.Text + " * " + tbSayı2.Text;
            sonuc = Convert.ToDouble(tbSayı1.Text) *
                Convert.ToDouble(tbSayı2.Text);
            tbSonuc.Text = sonuc.ToString();
        }

        private void bBöl_Click(object sender, EventArgs e)
        {
            double sonuc;
            tbIslem.Text = tbSayı1.Text + " / " + tbSayı2.Text;
            sonuc = Convert.ToDouble(tbSayı1.Text) /
                Convert.ToDouble(tbSayı2.Text);
            tbSonuc.Text = sonuc.ToString();
        }

        private void bKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
