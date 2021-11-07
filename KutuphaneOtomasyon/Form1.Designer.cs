
namespace KutuphaneOtomasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTeslimEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YoneticiPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapSorgulaToolStripMenuItem,
            this.kitapTeslimEtToolStripMenuItem,
            this.YoneticiPaneliToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapSorgulaToolStripMenuItem
            // 
            this.kitapSorgulaToolStripMenuItem.Name = "kitapSorgulaToolStripMenuItem";
            this.kitapSorgulaToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.kitapSorgulaToolStripMenuItem.Text = "Kitap Sorgula";
            this.kitapSorgulaToolStripMenuItem.Click += new System.EventHandler(this.kitapSorgulaToolStripMenuItem_Click);
            // 
            // kitapTeslimEtToolStripMenuItem
            // 
            this.kitapTeslimEtToolStripMenuItem.Name = "kitapTeslimEtToolStripMenuItem";
            this.kitapTeslimEtToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.kitapTeslimEtToolStripMenuItem.Text = "Kitap Teslim Et";
            this.kitapTeslimEtToolStripMenuItem.Click += new System.EventHandler(this.kitapTeslimEtToolStripMenuItem_Click);
            // 
            // YoneticiPaneliToolStripMenuItem
            // 
            this.YoneticiPaneliToolStripMenuItem.Name = "YoneticiPaneliToolStripMenuItem";
            this.YoneticiPaneliToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.YoneticiPaneliToolStripMenuItem.Text = "Yönetici Paneli";
            this.YoneticiPaneliToolStripMenuItem.Click += new System.EventHandler(this.YoneticiPaneliToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "KÜTÜPHANE OTOMASYONUNA HOŞGELDİNİZ!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapTeslimEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YoneticiPaneliToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

