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
    public partial class anaasayfa : Form
    {
        public anaasayfa()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TarifEkleForm tarifEkleForm = new TarifEkleForm();
            if (tarifEkleForm.ShowDialog() == DialogResult.OK)
            {
                string yeniTarif = tarifEkleForm.YeniTarif;
                if (!string.IsNullOrEmpty(yeniTarif))
                {
                    tariflistbox.Items.Add(yeniTarif);
                    MessageBox.Show("Tarif eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (tariflistbox.SelectedItem != null)
            {
                var secilen = tariflistbox.SelectedItem.ToString();
                var sonuc = MessageBox.Show($"'{secilen}' tarifini silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    tariflistbox.Items.Remove(tariflistbox.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir tarifi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndegerlendir_Click(object sender, EventArgs e)
        {
            if (tariflistbox.SelectedItem != null)
            {
                string secilenTarif = tariflistbox.SelectedItem.ToString();
                TarifDeğerlendirForm degerlendirForm = new TarifDeğerlendirForm(secilenTarif);

                if (degerlendirForm.ShowDialog() == DialogResult.OK)
                {
                    // ListBox'taki tarifin sonuna puan eklenir
                    string puanliTarif = $"{secilenTarif} - Puan: {degerlendirForm.Puan}";
                    int selectedIndex = tariflistbox.SelectedIndex;
                    tariflistbox.Items[selectedIndex] = puanliTarif;
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir tarif seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
