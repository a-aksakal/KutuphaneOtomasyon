using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void kitapSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormKitapSorgula formKitapSorgula = new FormKitapSorgula();
            formKitapSorgula.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kitapTeslimEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKitapTeslim formKitapTeslim = new FormKitapTeslim();
            this.Hide();
            formKitapTeslim.Show();
        }

        private void YoneticiPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGirisPaneli formGirisPaneli = new FormGirisPaneli();
            this.Hide();
            formGirisPaneli.Show();
            //FormYoneticiPaneli fromYoneticiPaneli = new FormYoneticiPaneli();
            //fromYoneticiPaneli.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
