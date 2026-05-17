using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ÖğrenciBilgiGirişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxSınıf.Items.AddRange(new string[] { "1. Sınıf", "2. Sınıf", "3. Sınıf", "4. Sınıf" });
        }

        private void btGöster_Click(object sender, EventArgs e)
        {
            int yas = DateTime.Today.Year - dateTimePickerDogumTarihi.Value.Year;
            if (dateTimePickerDogumTarihi.Value.Date > DateTime.Today.AddYears(-yas)) yas--;

            tbYaş.Text = yas.ToString();

            string mesaj = $"Numara: {numericUpDownNumara.Value}\n" +
                           $"Ad: {tbAd.Text}\n" +
                           $"Soyad: {tbSoyad.Text}\n" +
                           $"AGNO: {numericUpDownAGNO.Value}\n" +
                           $"Sınıf: {comboBoxSınıf.Text}\n" +
                           $"Doğum Tarihi: {dateTimePickerDogumTarihi.Value.ToShortDateString()}\n" +
                           $"Yaş: {yas}";

            MessageBox.Show(mesaj, "Öğrenci Bilgileri");
        }

        private void btTemizle_Click(object sender, EventArgs e)
        {
            numericUpDownNumara.Value = 0;
            tbAd.Clear();
            tbSoyad.Clear();
            numericUpDownAGNO.Value = 0;
            comboBoxSınıf.SelectedIndex = -1;
            dateTimePickerDogumTarihi.Value = DateTime.Today;
            tbYaş.Clear();
        }
    }
}
