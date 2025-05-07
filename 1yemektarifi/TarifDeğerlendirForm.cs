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
    public partial class TarifDeğerlendirForm : Form
    {
        public string TarifAdi { get; set; }
        public int Puan { get; set; }

        public TarifDeğerlendirForm(string tarifAdi)
        {
            InitializeComponent();
            TarifAdi = tarifAdi;
            label_tarifAdi.Text = $"Puan Verin: {TarifAdi}";
        }

        private void TarifDeğerlendirForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                comboBox_puan.Items.Add(i);
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
        
        }

        private void label_tarifAdi_Click(object sender, EventArgs e)
        {

        }

        private void button_kaydet_Click_1(object sender, EventArgs e)
        {
            if (comboBox_puan.SelectedItem != null)
            {
                Puan = (int)comboBox_puan.SelectedItem;
                MessageBox.Show($"{TarifAdi} tarifine {Puan} puan verdiniz.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir puan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
