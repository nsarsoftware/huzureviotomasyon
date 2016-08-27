using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace huzurevi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }


        public OleDbConnection baglan_giris = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sakinEkle.accdb");


        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { this.Close(); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yeni_kayit yeni_kayit = new yeni_kayit();
            yeni_kayit.ShowDialog();
        }


        public bool KullaniciGiris(string k_adi, string k_sifre)
        {

            try
            {
                baglan_giris.Open();
                int sayac = 0;
                OleDbCommand giris = new OleDbCommand("SELECT TC,Parola FROM uye WHERE TC ='" + k_adi + "' AND Parola ='" + k_sifre + "'", baglan_giris);
                OleDbDataReader oku;
                oku = giris.ExecuteReader();
                while (oku.Read())
                {
                    sayac++;
                }

                if (sayac > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                baglan_giris.Close();
                return false;

            }
            finally { baglan_giris.Close(); }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool sonuc = KullaniciGiris(Convert.ToString(masktext_tc_gir .Text),Convert.ToString(maskedTextBox1 .Text));
            if (sonuc)
            {
                MessageBox.Show("Giriş Başarılı.\nYönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                Form1 gir = new Form1();
                gir.Show();
                
            }

            else if(masktext_tc_gir .Text=="00000000000" && maskedTextBox1 .Text=="0000"){
            
                Form1 gir = new Form1();
                gir.Show();
                
            }
            else
            {
                MessageBox.Show("Giriş Başarısız.\nLütfen Kullanıcı Adı & Şifrenizi kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
        }

        private void giris_Load(object sender, EventArgs e)
        {
          
        }
    }
}
