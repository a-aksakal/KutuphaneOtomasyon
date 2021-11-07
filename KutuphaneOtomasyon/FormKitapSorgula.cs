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
    public partial class FormKitapSorgula : Form
    {
        public FormKitapSorgula()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataAdapter sqlDa = new SqlDataAdapter();
        SqlDataAdapter sqlAlinanDa = new SqlDataAdapter();
        DataSet sqlDs = new DataSet();

        
        void griddoldur()
        {
            sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlDa = new SqlDataAdapter("SELECT * FROM kitaplar",sqlCon);
            sqlDs = new DataSet();
            sqlCon.Open();
            sqlCmd.CommandText = "Select distinct Kitap_turu From Kitaplar";
            sqlCmd.Connection = sqlCon;
            SqlDataReader sqlDr;
            sqlDa.Fill(sqlDs,"kitaplar");
            dataGridView1.DataSource = sqlDs.Tables["kitaplar"];
            sqlDr = sqlCmd.ExecuteReader();
            while (sqlDr.Read())
            {
                comboBoxTur.Items.Add(sqlDr["Kitap_turu"]);
            }
            sqlCon.Close();
        }

        public void VeriAra()
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Kitaplar where Kitap_adi like '%" + txtKitapAdi.Text + "%' AND Kitap_Turu like '%" + comboBoxTur.Text + "%' AND Yazar_Adi like '%" + txtYazarAdi.Text + "%' AND Yazar_Soyadi like '%" + txtYazarSoyadi.Text + "%' AND Yayin_Evi like '%" + txtYayinEvi.Text + "%' AND Basim_Yili like '%" + txtBasimYili.Text + "%'", sqlCon);
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlCmd.ExecuteNonQuery();
            sqlDa.SelectCommand = sqlCmd;
            DataTable sqlDt = new DataTable();
            sqlDa.Fill(sqlDt);
            dataGridView1.DataSource = sqlDt;
            sqlCon.Close();
        }

        void TxtAktar()
        {
            txtKitapAdi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxTur.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYazarAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYazarSoyadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtYayinEvi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBasimYili.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        void TxtSil()
        {
            txtKitapAdi.Text = null;
            comboBoxTur.Text = null;
            txtYazarAdi.Text = null;
            txtYazarSoyadi.Text = null;
            txtYayinEvi.Text = null;
            txtBasimYili.Text = null;
        }
        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formAnasayfa = new Form1();
            formAnasayfa.Show();
            this.Hide();
        }

        private void kitapTeslimEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKitapTeslim formKitapTeslim = new FormKitapTeslim();
            formKitapTeslim.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormKitapSorgula_Load(object sender, EventArgs e)
        {
            griddoldur();
            lblUyari.Hide();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            VeriAra();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAktar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAktar();
        }

        private void txtKitapAdi_Click(object sender, EventArgs e)
        {
            TxtSil();
        }

        private void comboBoxTur_Click(object sender, EventArgs e)
        {
            TxtSil();
        }

        private void txtYazarAdi_Click(object sender, EventArgs e)
        {
            TxtSil();
        }

        private void txtYazarSoyadi_Click(object sender, EventArgs e)
        {
            TxtSil();
        }

        private void txtYayinEvi_Click(object sender, EventArgs e)
        {
            TxtSil();
        }

        private void txtBasimYili_Click(object sender, EventArgs e)
        {
            TxtSil();
        }



        private void btnKitabiAl_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "")
            {
                MessageBox.Show("Materyal alabilmek için lütfen isminizi giriniz!");
                lblUyari.Show();
            }
            else if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value) == 0)
            {
                MessageBox.Show("Seçmek istediğiniz materyal stoklarımızda mevcut değildir.");
            }
            else
            {
                FormKitapSorgula formKitapSorgula = new FormKitapSorgula();
                sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
                sqlDa = new SqlDataAdapter("SELECT * FROM kitaplar", sqlCon);
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "update  kitaplar set Stok_durumu = Stok_durumu-1 where Kitap_Adi='" + txtKitapAdi.Text + "'";
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "insert into AlinanKitaplar(Kitap_Adi,Kitap_Turu,Yazar_Adi,Yazar_Soyadi,Yayin_Evi,Basim_Yili,Stok_Durumu,Kullanici) values('" + txtKitapAdi.Text + "','" + comboBoxTur.Text + "','" + txtYazarAdi.Text + "','" + txtYazarSoyadi.Text + "','" + txtYayinEvi.Text + "'," + txtBasimYili.Text + ", +1 ,'" + txtKullanici.Text + "')";
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Merhaba: " + txtKullanici.Text + " Seçmiş olduğunuz " + txtKitapAdi.Text + " materyali adınıza kayıt edilmiştir. Zarar vermeden kullanmanızı dileriz...");
                lblUyari.Hide();
                griddoldur();
            }
            
            
            

        }

        private void txtBasimYili_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


    }
}
