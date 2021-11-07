using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneOtomasyon
{
    public partial class FormYoneticiPaneli : Form
    {
        public FormYoneticiPaneli()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection();
        SqlDataAdapter sqlDa = new SqlDataAdapter();
        SqlCommand sqlCmd = new SqlCommand();
        DataSet sqlDs = new DataSet();

        void griddoldur()
        {
            sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlDa = new SqlDataAdapter("SELECT * FROM kitaplar", sqlCon);
            sqlDs = new DataSet();
            sqlCon.Open();
            sqlDa.Fill(sqlDs, "kitaplar");
            dataGridView1.DataSource = sqlDs.Tables["kitaplar"];
            sqlCon.Close();
        }

        public void VeriEkle()
        {
            sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlDa = new SqlDataAdapter("SELECT * FROM kitaplar", sqlCon);
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "insert into kitaplar(Kitap_Adi,Kitap_Turu,Yazar_Adi,Yazar_Soyadi,Yayin_Evi,Basim_Yili,Stok_Durumu) values('" + txtKitapAdi.Text + "','" + txtKitapTuru.Text + "','" + txtYazarAdi.Text + "','" + txtYazarSoyadi.Text + "','" + txtYayinEvi.Text + "'," + txtBasimYili.Text + "," + txtStok.Text + ")";
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            griddoldur();
        }

        public void VeriGuncelle()
        {
            sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlDa = new SqlDataAdapter("SELECT * FROM kitaplar", sqlCon);
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "update  kitaplar set Kitap_Turu='" + txtKitapTuru.Text + "',Yazar_Adi='" + txtYazarAdi.Text + "',Yazar_Soyadi='" + txtYazarSoyadi.Text + "',Yayin_Evi='" + txtYayinEvi.Text + "',Basim_Yili=" + txtBasimYili.Text + ",Stok_Durumu=" + txtStok.Text + " where Kitap_Adi='" + txtKitapAdi.Text + "'";
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            griddoldur();
        }

        public void VeriSil()
        {
            sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlDa = new SqlDataAdapter("SELECT * FROM kitaplar", sqlCon);
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "delete from kitaplar where Kitap_Adi='" + txtKitapAdi.Text + "'";
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            griddoldur();
        }

        void TxtAktar()
        {
            txtKitapAdi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKitapTuru.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYazarAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYazarSoyadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtYayinEvi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBasimYili.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        void TxtSil()
        {
            txtKitapAdi.Text = null;
            txtKitapTuru.Text = null;
            txtYazarAdi.Text = null;
            txtYazarSoyadi.Text = null;
            txtYayinEvi.Text = null;
            txtBasimYili.Text = null;
            txtStok.Text = null;
        }

        public void VeriAra()
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Kitaplar where Kitap_adi like '%" + txtKitapAdi.Text + "%' AND Kitap_Turu like '%" + txtKitapTuru.Text + "%' AND Yazar_Adi like '%" + txtYazarAdi.Text + "%' AND Yazar_Soyadi like '%" + txtYazarSoyadi.Text + "%' AND Yayin_Evi like '%" + txtYayinEvi.Text + "%' AND Basim_Yili like '%" + txtBasimYili.Text + "%'", sqlCon);
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlCmd.ExecuteNonQuery();
            sqlDa.SelectCommand = sqlCmd;
            DataTable sqlDt = new DataTable();
            sqlDa.Fill(sqlDt);
            dataGridView1.DataSource = sqlDt;
            sqlCon.Close();
        }
        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formAnaSayfa = new Form1();
            formAnaSayfa.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormYoneticiPaneli_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            VeriEkle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            VeriGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            VeriSil();
        }

        private void btnVerilenler_Click(object sender, EventArgs e)
        {
            FormAlinanlar formAlinanlar = new FormAlinanlar();
            formAlinanlar.Show();
            sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlDa = new SqlDataAdapter("SELECT * FROM AlinanKitaplar", sqlCon);
            sqlDs = new DataSet();
            sqlCon.Open();
            sqlDa.Fill(sqlDs, "AlinanKitaplar");
           formAlinanlar.dataGridView1.DataSource = sqlDs.Tables["AlinanKitaplar"];
            sqlCon.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAktar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAktar();
        }

        private void txtKitapAdi_Click(object sender, EventArgs e)
        {
            TxtSil();
        }

        private void txtKitapTuru_Click(object sender, EventArgs e)
        {

        }

        private void txtYazarAdi_Click(object sender, EventArgs e)
        {

        }

        private void txtYazarSoyadi_Click(object sender, EventArgs e)
        {

        }

        private void txtYayinEvi_Click(object sender, EventArgs e)
        {

        }

        private void txtBasimYili_Click(object sender, EventArgs e)
        {

        }

        private void txtStok_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            VeriAra();
        }
    }
}
