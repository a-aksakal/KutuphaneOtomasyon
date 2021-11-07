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
    public partial class FormKitapTeslim : Form
    {
        public FormKitapTeslim()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataAdapter sqlDa = new SqlDataAdapter();
        SqlDataAdapter sqlAlinanDa = new SqlDataAdapter();
        DataSet sqlDs = new DataSet();
        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formAnaSayfa = new Form1();
            formAnaSayfa.Show();
            this.Hide();
        }

        private void kitapSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKitapSorgula formKitapSorgula = new FormKitapSorgula();
            formKitapSorgula.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM AlinanKitaplar where Kitap_adi like '%" + txtKitapAdi.Text + "%' AND Kullanici like '%" + txtKullanici.Text + "%'", sqlCon);
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlCmd.ExecuteNonQuery();
            sqlDa.SelectCommand = sqlCmd;
            DataTable sqlDt = new DataTable();
            sqlDa.Fill(sqlDt);
            dataGridView1.DataSource = sqlDt;
            sqlCon.Close();
        }

        void griddoldur()
        {
            sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlDa = new SqlDataAdapter("SELECT * FROM AlinanKitaplar", sqlCon);
            sqlDs = new DataSet();
            sqlCon.Open();
            sqlDa.Fill(sqlDs, "AlinanKitaplar");
            dataGridView1.DataSource = sqlDs.Tables["AlinanKitaplar"];
            sqlCon.Close();
        }

        void TxtAktar()
        {
            txtKullanici.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtKitapAdi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void FormKitapTeslim_Load(object sender, EventArgs e)
        {
            griddoldur();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAktar();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value) == 1)
            {
                sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
                sqlDa = new SqlDataAdapter("SELECT * FROM AlinanKitaplar", sqlCon);
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "delete from AlinanKitaplar where Kitap_Adi='" + txtKitapAdi.Text + "' AND Kullanici='" + txtKullanici.Text +"'";
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                griddoldur();
            }
            else
            {
                sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
                sqlDa = new SqlDataAdapter("SELECT * FROM AlinanKitaplar", sqlCon);
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "update  AlinanKitaplar set Stok_durumu = Stok_durumu-1 where Kitap_Adi='" + txtKitapAdi.Text + "' AND Kullanici='"+txtKullanici.Text+"'";
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                sqlDa = new SqlDataAdapter("SELECT * FROM Kitaplar", sqlCon);
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "update Kitaplar set Stok_durumu = Stok_durumu+1 where Kitap_Adi='" + dataGridView1.CurrentRow.Cells[0].Value + "' AND Kitap_Turu='" + dataGridView1.CurrentRow.Cells[1].Value + "' AND Yazar_Adi = '" + dataGridView1.CurrentRow.Cells[2].Value + "' AND Yazar_Soyadi = '" + dataGridView1.CurrentRow.Cells[3].Value + "' AND Yayin_Evi = '" + dataGridView1.CurrentRow.Cells[4].Value + "' AND Basim_Yili = " + dataGridView1.CurrentRow.Cells[5].Value + "";
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                griddoldur();
                MessageBox.Show("Materyal Başarıyla Teslim Edilmiştir.");
            }
        }
    }
}
