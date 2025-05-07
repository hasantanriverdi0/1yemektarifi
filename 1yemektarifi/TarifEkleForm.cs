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
    public partial class TarifEkleForm : Form
    {
        public string YeniTarif { get; private set; }

        public TarifEkleForm()
        {
            InitializeComponent();
        }

        private void TarifEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void button_kaydet_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBox_tarif.Text))
            {
                YeniTarif = richTextBox_tarif.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tarif boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
