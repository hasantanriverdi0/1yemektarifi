namespace _1yemektarifi
{
    partial class TarifDeğerlendirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarifDeğerlendirForm));
            this.comboBox_puan = new System.Windows.Forms.ComboBox();
            this.label_tarifAdi = new System.Windows.Forms.Label();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_puan
            // 
            this.comboBox_puan.FormattingEnabled = true;
            this.comboBox_puan.Location = new System.Drawing.Point(41, 144);
            this.comboBox_puan.Name = "comboBox_puan";
            this.comboBox_puan.Size = new System.Drawing.Size(210, 21);
            this.comboBox_puan.TabIndex = 0;
            // 
            // label_tarifAdi
            // 
            this.label_tarifAdi.AutoSize = true;
            this.label_tarifAdi.Location = new System.Drawing.Point(12, 116);
            this.label_tarifAdi.Name = "label_tarifAdi";
            this.label_tarifAdi.Size = new System.Drawing.Size(0, 13);
            this.label_tarifAdi.TabIndex = 2;
            this.label_tarifAdi.Click += new System.EventHandler(this.label_tarifAdi_Click);
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_kaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_kaydet.FlatAppearance.BorderSize = 0;
            this.button_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_kaydet.Location = new System.Drawing.Point(93, 178);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(100, 44);
            this.button_kaydet.TabIndex = 4;
            this.button_kaydet.Text = "Tarif Değerlendir";
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click_1);
            // 
            // TarifDeğerlendirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(285, 250);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.label_tarifAdi);
            this.Controls.Add(this.comboBox_puan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TarifDeğerlendirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarif Değerlendir";
            this.Load += new System.EventHandler(this.TarifDeğerlendirForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_puan;
        private System.Windows.Forms.Label label_tarifAdi;
        private System.Windows.Forms.Button button_kaydet;
    }
}