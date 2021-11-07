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
    public partial class FormGirisPaneli : Form
    {
        public FormGirisPaneli()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection();
        SqlDataAdapter sqlDa = new SqlDataAdapter();
        SqlCommand sqlCmd = new SqlCommand();
        DataSet sqlDs = new DataSet();
        SqlDataReader sqlDr;

        private void FormGirisPaneli_Load(object sender, EventArgs e)
        {
            lblHataliGiris.Hide();
        }

        private void FormGirisPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 formAnasayfa = new Form1();
            this.Hide();
            formAnasayfa.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            FormYoneticiPaneli formYoneticiPaneli = new FormYoneticiPaneli();
            string sorgu = "SELECT * FROM Sifreler where Kullanici_Adi=@Kullanici_Adi AND Sifre=@Sifre";
            sqlCon = new SqlConnection("Data Source=DESKTOP-KL3DULI\\SQLEXPRESS;Initial Catalog=Wissen;Integrated Security=True");
            sqlCmd = new SqlCommand(sorgu, sqlCon);
            sqlCmd.Parameters.AddWithValue("@Kullanici_Adi", txtKullaniciAdi.Text);
            sqlCmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            sqlCon.Open();
            sqlDr = sqlCmd.ExecuteReader();
            if (sqlDr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                formYoneticiPaneli.Show();
                this.Hide();
            }
            else
            {
                lblHataliGiris.Show();
            }
            sqlCon.Close();
        }

        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
            
        }
    }
}
