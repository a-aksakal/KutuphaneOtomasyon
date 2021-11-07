
namespace KutuphaneOtomasyon
{
    partial class FormKitapSorgula
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTur = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKitabiAl = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTeslimEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.lblUyari = new System.Windows.Forms.Label();
            this.txtBasimYili = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(255, 93);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(312, 20);
            this.txtKitapAdi.TabIndex = 1;
            this.txtKitapAdi.Click += new System.EventHandler(this.txtKitapAdi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar Adı";
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(255, 147);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(312, 20);
            this.txtYazarAdi.TabIndex = 3;
            this.txtYazarAdi.Click += new System.EventHandler(this.txtYazarAdi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar Soyadı";
            // 
            // txtYazarSoyadi
            // 
            this.txtYazarSoyadi.Location = new System.Drawing.Point(255, 172);
            this.txtYazarSoyadi.Name = "txtYazarSoyadi";
            this.txtYazarSoyadi.Size = new System.Drawing.Size(312, 20);
            this.txtYazarSoyadi.TabIndex = 4;
            this.txtYazarSoyadi.Click += new System.EventHandler(this.txtYazarSoyadi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yayın Evi";
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Location = new System.Drawing.Point(255, 197);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(312, 20);
            this.txtYayinEvi.TabIndex = 5;
            this.txtYayinEvi.Click += new System.EventHandler(this.txtYayinEvi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Basım Yılı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kitap Türü";
            // 
            // comboBoxTur
            // 
            this.comboBoxTur.FormattingEnabled = true;
            this.comboBoxTur.Location = new System.Drawing.Point(255, 118);
            this.comboBoxTur.Name = "comboBoxTur";
            this.comboBoxTur.Size = new System.Drawing.Size(312, 21);
            this.comboBoxTur.TabIndex = 2;
            this.comboBoxTur.Click += new System.EventHandler(this.comboBoxTur_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(409, 222);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(76, 47);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(781, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "_________________________________________________________________________________" +
    "________________________________________________";
            // 
            // btnKitabiAl
            // 
            this.btnKitabiAl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKitabiAl.Location = new System.Drawing.Point(491, 222);
            this.btnKitabiAl.Name = "btnKitabiAl";
            this.btnKitabiAl.Size = new System.Drawing.Size(76, 47);
            this.btnKitabiAl.TabIndex = 8;
            this.btnKitabiAl.Text = "Kitabı Al";
            this.btnKitabiAl.UseVisualStyleBackColor = false;
            this.btnKitabiAl.Click += new System.EventHandler(this.btnKitabiAl_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaMenüToolStripMenuItem,
            this.kitapTeslimEtToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            this.anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            this.anaMenüToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.anaMenüToolStripMenuItem.Text = "Ana Menü";
            this.anaMenüToolStripMenuItem.Click += new System.EventHandler(this.anaMenüToolStripMenuItem_Click);
            // 
            // kitapTeslimEtToolStripMenuItem
            // 
            this.kitapTeslimEtToolStripMenuItem.Name = "kitapTeslimEtToolStripMenuItem";
            this.kitapTeslimEtToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.kitapTeslimEtToolStripMenuItem.Text = "Kitap Teslim Et";
            this.kitapTeslimEtToolStripMenuItem.Click += new System.EventHandler(this.kitapTeslimEtToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(260, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 39);
            this.label8.TabIndex = 30;
            this.label8.Text = "KİTAP SORGULA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "İsminiz:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.BackColor = System.Drawing.SystemColors.Window;
            this.txtKullanici.Location = new System.Drawing.Point(47, 90);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(100, 20);
            this.txtKullanici.TabIndex = 9;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(33, 118);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(123, 13);
            this.lblUyari.TabIndex = 33;
            this.lblUyari.Text = "LÜTFEN İSİM GİRİNİZ !";
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Location = new System.Drawing.Point(255, 227);
            this.txtBasimYili.Mask = "0000";
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(50, 20);
            this.txtBasimYili.TabIndex = 6;
            this.txtBasimYili.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBasimYili_MaskInputRejected);
            this.txtBasimYili.Click += new System.EventHandler(this.txtBasimYili_Click);
            // 
            // FormKitapSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.txtBasimYili);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKitabiAl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.comboBoxTur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYayinEvi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYazarSoyadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormKitapSorgula";
            this.Text = "FormKitapSorgula";
            this.Load += new System.EventHandler(this.FormKitapSorgula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKitabiAl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaMenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapTeslimEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtKitapAdi;
        public System.Windows.Forms.TextBox txtYazarAdi;
        public System.Windows.Forms.TextBox txtYazarSoyadi;
        public System.Windows.Forms.TextBox txtYayinEvi;
        public System.Windows.Forms.ComboBox comboBoxTur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.MaskedTextBox txtBasimYili;
    }
}