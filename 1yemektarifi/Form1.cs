using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1yemektarifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        anaasayfa anaasayfa = new anaasayfa();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            string ad = textBox_ad.Text;
            string numara = textBox_no.Text;

            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(numara))
            {
                bool numaraSadeceSayiMi = numara.All(char.IsDigit);
                bool adSadeceHarfMi = ad.All(c => char.IsLetter(c) || c == ' ');

                if (numaraSadeceSayiMi && adSadeceHarfMi)
                {
                    if (textBox_no.Text.Length < 10)
                    {
                        MessageBox.Show("Telefon numarası en az 10 haneli olmalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (anaasayfa == null)
                        {
                            anaasayfa = new anaasayfa();
                        }
                        anaasayfa.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Ad Soyad sadece harflerden oluşmalı ve Telefon Numarası sayılardan oluşmalıdır.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ad Soyad ve Telefon Numarası bölümlerini eksiksiz doldurun.");
            }

        }
    }
}
