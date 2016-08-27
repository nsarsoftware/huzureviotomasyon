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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SAKIN DATA
        public OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sakinEkle.accdb");
        public OleDbCommand komut = new OleDbCommand();
        public DataSet tablo = new DataSet();

        

        //AILE DATA
        public OleDbConnection baglan2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sakinEkle.accdb");
        public OleDbCommand komut2 = new OleDbCommand();
        public DataSet tablo2 = new DataSet();

        //SAKIN VERI KAYIT AKTARIMI
        public void sakin_kayit()
        {
            baglan.Open();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from ekle", baglan);
            tablo.Clear();
            adaptor.Fill(tablo, "ekle");
            dataGrid_sakin.DataSource = tablo.Tables["ekle"];
            datagrid_analiz.DataSource = tablo.Tables["ekle"];
            adaptor.Dispose();
            baglan.Close();
        }

        //AILE VERI KAYIT AKTARIMI
        public void aile_kayit2()
        {
            baglan2.Open();
            OleDbDataAdapter adaptor2 = new OleDbDataAdapter("Select * from ekle_aile", baglan2);
            tablo2.Clear();
            adaptor2.Fill(tablo2, "ekle_aile");
            dataGrid_aile.DataSource = tablo2.Tables["ekle_aile"];
            adaptor2.Dispose();
            baglan2.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            sakin_kayit();
            aile_kayit2();
            btn_kaydet.Enabled = true;
            timer1.Enabled = true;

            webBrowser1.Navigate("http://ensarguclu.com/huzurevleri-ile-huzurevi-yasli-bakim-ve-rehabilitasyon-merkezleri-yonetmeligi/");


            //combobox ilk gosterımler
            combo_dyer.SelectedIndex = 0;
            combo_kan.SelectedIndex = 0;
            combo_meslek.SelectedIndex = 0;
            combo_sgk.SelectedIndex = 0;

        }



        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                String cins = "";
                if (radioButton1.Checked == true)
                { cins = "Bay"; }
                else if (radioButton2.Checked == true)
                { cins = "Bayan"; }
                else
                { MessageBox.Show("Lütfen Cinsiyetinizi seçiniz."); }


                //Kişi_adi ilk harf büyüt
                string sakin_adi = "";
                sakin_adi = textBox2.Text.Substring(0, 1).ToUpper() + textBox2.Text.Substring(1, textBox2.Text.Length - 1).ToLower();


                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "insert into ekle(TC,ADI,SOYADI,GSM,DOGUM_YERI,D_TARIHI,CINSIYET,KAN_GRUBU,MESLEK,GUVENCE,ADRES)values('" + masktext_tc.Text + "','" + sakin_adi + "','" + textBox3.Text.ToUpper() + "','" + masktext_cep.Text + "','" + combo_dyer.Text + "'," + masktext_dt.Text + ",'" + cins + "','" + combo_kan.Text + "','" + combo_meslek.Text + "','" + combo_sgk.Text + "','" + textBox5.Text + "')";
                komut.ExecuteNonQuery();


                MessageBox.Show("Kayıt Başarılı");
                baglan.Close();
                sakin_kayit();

            }

            catch { MessageBox.Show("Gerekli kısımları doldurunuz", "Genel Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { this.Close(); }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }


        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.ensarguclu.com");
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkmak istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { this.Close(); }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Temızle
            foreach (Control temiz in this.groupBox1.Controls)
            {
                if (temiz is MaskedTextBox || temiz is TextBox || temiz is ComboBox)
                {
                    temiz.Text = "";
                }
            }

        }

        private void btn_kaydet2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;
                default:
                    e.Handled = true; break;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;
                default:
                    e.Handled = true; break;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;
                default:
                    e.Handled = false; break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combo_dyer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public static string btn_analizci = btn_analizci;


        private void btn_analiz(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;
                default:
                    e.Handled = false; break;
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;
                default:
                    e.Handled = false; break;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '.':
                case '-':
                case '\b':

                    break;
                default:
                    e.Handled = false; break;
            }
        }

        //Kaydet butonu aktıflestırme
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //Kayıt silme işlemi
        private void btn_sil(object sender, EventArgs e)
        {
            try
            {
                if (txt_ara_sil.TextLength == 11)
                {

                    if (MessageBox.Show("Silmek istediğinizden eminmisiniz?", "Silme uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                         string sorgu = "delete from ekle where TC='" + txt_ara_sil.Text + "'";
                        OleDbCommand kmt = new OleDbCommand(sorgu, baglan);
                        baglan.Open();
                        //kmt.Connection = baglan;

                        kmt.ExecuteNonQuery();
                        baglan.Close();
                        sakin_kayit();
                        MessageBox.Show("Kaydınız Silindi", "Silinme uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    else { MessageBox.Show("Silmek istediğiniz kişinin TC noyu sağdaki yeşil kısma yazınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                }

                else { MessageBox.Show("Silmek istediğiniz kişinin TC noyu sağdaki yeşil kısma yazınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
             catch
            {
                MessageBox.Show("Catch kısmı !", "Silinme Uyarısı");

            }
        }

        private void btn_kydt_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkmak istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { this.Close(); }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Temızle
            foreach (Control temiz in this.groupBox4.Controls)
            {
                if (temiz is MaskedTextBox || temiz is TextBox || temiz is ComboBox)
                {
                    temiz.Text = "";
                }
            }
        }
        public String cins = "";

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

            try
            {
                
                if (radioButton1.Checked == true)
                { cins = "Bay"; }
                else if (radioButton2.Checked == true)
                { cins = "Bayan"; }
                else
                { MessageBox.Show("Lütfen Cinsiyetinizi seçiniz."); }

                if (radioButton1.Checked == true || radioButton2.Checked == true)
                {
                    //Kişi_adi ilk harf büyüt
                    string sakin_adi = "";
                    sakin_adi = textBox2.Text;

                    Random rnd = new Random();
                    int kayit = rnd.Next(999999999);
                    resim(yol, @"resimler\" + kayit + ".jpg");

                    baglan.Open();
                    komut.Connection = baglan;
                    komut.CommandText = "insert into ekle(TC,ADI,SOYADI,GSM,DOGUM_YERI,D_TARIHI,CINSIYET,KAN_GRUBU,MESLEK,GUVENCE,ADRES,RESIM)values('" + masktext_tc.Text + "','" + sakin_adi.ToUpper() + "','" + textBox3.Text.ToUpper() + "','" + masktext_cep.Text + "','" + combo_dyer.Text + "','" + masktext_dt.Text + "','" + cins + "','" + combo_kan.Text + "','" + combo_meslek.Text + "','" + combo_sgk.Text + "','" + textBox5.Text + @"','resimler\" + kayit + ".jpg')";
                    komut.ExecuteNonQuery();

                    ////checkboxlar ıcın
                    komut = new OleDbCommand("insert into hastaliklar(Tc,Tansiyon,Seker,Kanser,Felc,KemikErimesi,Romatizma,Migren,Kolestrol,Diyabet,KalpCarpintisi,GastritUlser,DamarSertligi,Obezite,IdrarTutamama,GormeBozukluklari)values('" + masktext_tc.Text + "' , " + checkBox1.Checked + "," + checkBox2.Checked + "," + checkBox3.Checked + "," + checkBox4.Checked + "," + checkBox5.Checked + "," + checkBox6.Checked + "," + checkBox7.Checked + "," + checkBox8.Checked + "," + checkBox9.Checked + "," + checkBox10.Checked + "," + checkBox11.Checked + "," + checkBox12.Checked + "," + checkBox13.Checked + "," + checkBox14.Checked + "," + checkBox15.Checked + ")", baglan);
                    komut.ExecuteNonQuery();
                    baglan.Close();

                    MessageBox.Show("Sakin kaydı başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    sakin_kayit();
                }
            }
            catch
            {
                baglan.Close();
                MessageBox.Show("Gerekli kısımları doldurunuz ve sakinin kişisel resmini yüklemeniz gerekmektedir.\n\n Eğer sorun devam ediyorsa aynı kişiyi(TC) ekleyemezsiniz!", "Genel Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_temiz_Click(object sender, EventArgs e)
        {
            masktext_tc.Enabled = true;
            //Temızle
            foreach (Control temiz in this.groupBox1.Controls)
            {
                if (temiz is MaskedTextBox || temiz is TextBox || temiz is ComboBox)
                {
                    temiz.Text = "";
                }
            }

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkmak istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { this.Close(); }

        }


        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek istediğinizden eminmisiniz?", "Silme uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                   // dataGrid_sakin.Rows.Remove(dataGrid_sakin.CurrentRow); Seçilen row silinebılır
                    string sorgu = "delete from ekle where TC='" /*+ dataGrid_sakin.CurrentRow.Cells[0].Value.ToString() + "' or TC ='"*/+ txt_ara_sil.Text+"'";
                    OleDbCommand kmt = new OleDbCommand(sorgu, baglan);
                    baglan.Open();
                    kmt.ExecuteNonQuery();
                    baglan.Close();
                    sakin_kayit();
                    MessageBox.Show("Kaydınız Silindi", "Silinme uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }

                else { baglan.Close();
                    MessageBox.Show("Silmek istediğiniz kişinin TC noyu sağdaki beyaz kısma yazınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }

            catch { baglan.Close();
                MessageBox.Show("Böyle bir kayıt bulunamadı", "Silinme Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            baglan.Open();
            OleDbCommand guncelle = new OleDbCommand("select * from ekle where TC='" + Convert.ToString(txt_ara_sil.Text) + "'", baglan);
            OleDbDataReader guncel_oku = null;
            guncel_oku = guncelle.ExecuteReader();


            if (guncel_oku.Read())
            {

                masktext_tc.Enabled = false;
                masktext_tc.Text = Convert.ToString(guncel_oku[0]);
                textBox2.Text = Convert.ToString(guncel_oku[1]);
                textBox3.Text = Convert.ToString(guncel_oku[2]);
                masktext_cep.Text = Convert.ToString(guncel_oku[3]);
                combo_dyer.Text = Convert.ToString(guncel_oku[4]);
                masktext_dt.Text = Convert.ToString(guncel_oku[5]);

                string cinsal = Convert.ToString(guncel_oku[6]);
                if (cinsal == "Bay")
                {
                    radioButton1.Checked = true;
                }
                else if (cinsal == "Bayan")
                {
                    radioButton2.Checked = true;

                }
                cinsal = Convert.ToString(guncel_oku[6]);
                combo_kan.Text = Convert.ToString(guncel_oku[7]);
                combo_meslek.Text = Convert.ToString(guncel_oku[8]);
                combo_sgk.Text = Convert.ToString(guncel_oku[9]);
                textBox5.Text = Convert.ToString(guncel_oku[10]);
                baglan.Close();
            }
            else
            { MessageBox.Show("Böyle bir kayıt bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error); baglan.Close(); }
               
            
           
        }

        private void dataGrid_sakin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_sakin_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGrid_sakin.Rows[dataGrid_sakin.CurrentRow.Index].Cells["TC"].Value);
                masktext_tc.Text = id.ToString();
            }
            catch { }

        }

        private void combo_sgk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_kydt_Click_1(object sender, EventArgs e)
        {
            try
            {
                String cins2 = "";
                if (radioButton4.Checked == true)
                { cins2 = "Bay"; }
                else if (radioButton3.Checked == true)
                { cins2 = "Bayan"; }
                else
                { MessageBox.Show("Lütfen Cinsiyetinizi seçiniz."); }

               if(radioButton4.Checked==true || radioButton3.Checked==true)
                {
                    //Kişi_adi ilk harf büyüt
                    string aile_adi2 = "";
                    aile_adi2 = txt_aile_ad.Text.Substring(0, 1).ToUpper() + txt_aile_ad.Text.Substring(1, txt_aile_ad.Text.Length - 1).ToLower();


                    baglan2.Open();
                    komut2.Connection = baglan2;
                    komut2.CommandText = "insert into ekle_aile(TC,ADI,SOYADI,GSM_NO,GSM_NO2,EV_TEL,CINSIYET,MESLEK,SEHIR,ADRES)values('" + mask_tc2.Text + "','" + txt_aile_ad.Text + "','" + txt_aile_soyad.Text.ToUpper() + "','" + mask_aile_no.Text + "','" + mask_aile_no2.Text + "'," +mask .Text + ",'" + cins2 + "','" + com_aile_mes.Text + "','" + com_aile_sehir.Text + "','" + txt_aile_adres.Text + "')";
                    komut2.ExecuteNonQuery();


                    MessageBox.Show("Aile kaydı başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    baglan2.Close();
                    aile_kayit2();
                }
                

            }
            catch { baglan2.Close(); MessageBox.Show("Gerekli kısımları doldurunuz\n\nAynı kişiyi(TC) ekleyemezsiniz!", "Genel Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); }
         }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden eminmisiniz?", "Çıkış uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { this.Close(); }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden eminmisiniz?", "Silme uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //dataGrid_aile.Rows.Remove(dataGrid_aile.CurrentRow); // Seçilen sütünu silebilirz

                string sorgu_aile = "delete from ekle_aile where TC='"/* + dataGrid_aile.CurrentRow.Cells[0].Value.ToString() + "' or*/+textBox1.Text+ "'";
                
                OleDbCommand kmt_aile = new OleDbCommand(sorgu_aile, baglan2);
                baglan2.Open();
                kmt_aile.ExecuteNonQuery();
                baglan2.Close();
                aile_kayit2();

                MessageBox.Show("Kaydınız silindi.", "Silme durumu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
            baglan2.Close();
            MessageBox.Show("Kayıt bulunamadı. Özür dileriz.", "Silme uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            mask_tc2.Enabled = true;
            //Temızle
            foreach (Control temiz in this.groupBox4.Controls)
            {
                if (temiz is MaskedTextBox || temiz is TextBox || temiz is ComboBox)
                {
                    temiz.Text = "";
                }
            }
        }

        private void txt_ara_sil_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;
                default:
                    e.Handled = false; break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*  DataTable dt = new DataTable();
              baglan.Open();
              OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from hastaliklar ", baglan);
              tablo.Clear();
              adaptor.Fill(dt);
              MessageBox.Show(dt.Rows[0]["Tansiyon"].ToString());
              MessageBox.Show(dt.Rows[0]["Seker"].ToString());
              baglan.Close();*/
        }

        private void masktext_tc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (masktext_tc.Text.Length == 11 && masktext_cep.Text.Length == 14 && masktext_dt.Text.Length == 10)
            {
                btn_kaydet.Enabled = true;
            }
            else
                btn_kaydet.Enabled = false;
        }

        private void masktext_cep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (masktext_tc.Text.Length == 11 && masktext_cep.Text.Length == 14 && masktext_dt.Text.Length == 10)
            {
                btn_kaydet.Enabled = true;
            }
            else
                btn_kaydet.Enabled = false;
        }

        private void masktext_dt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (masktext_tc.Text.Length == 11 && masktext_cep.Text.Length == 14 && masktext_dt.Text.Length == 10)
            {
                btn_kaydet.Enabled = true;
            }
            else
                btn_kaydet.Enabled = false;
        }

        private void txt_ara_sil_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_ara_sil.Text == "Silinecek&Güncellenecek kişinin TC gir")
                txt_ara_sil.Text = "";
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox6.Text == "Aranacak kişi TC gir")
                textBox6.Text = "";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            { cins = "Bay"; }
            else if (radioButton3.Checked == true)
            { cins = "Bayan"; }
            else
            { MessageBox.Show("Lütfen Cinsiyetinizi seçiniz."); }

            OleDbCommand guncellemem = new OleDbCommand("Update ekle_aile Set ADI='" + txt_aile_ad.Text + "',SOYADI='" + txt_aile_soyad.Text + "',GSM_NO='" + mask_aile_no.Text + "',GSM_NO2='" + mask_aile_no2.Text + "',EV_TEL='" + mask.Text + "',CINSIYET='" + cins + "',MESLEK='" + com_aile_mes.Text + "',SEHIR='" + com_aile_sehir.Text + "',ADRES='" + txt_aile_adres.Text + "'Where TC='" + textBox1.Text + "'", baglan2);
            baglan2.Open();
            guncellemem.ExecuteNonQuery();
            baglan2.Close();
            MessageBox.Show("Güncelleme başarılı.", "Genel Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            aile_kayit2();
        }

        public string guncel_sakin = "";

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { cins = "Bay"; }
            else if (radioButton2.Checked == true)
            { cins = "Bayan"; }
            else
            { MessageBox.Show("Lütfen Cinsiyetinizi seçiniz."); }

            OleDbCommand guncellemem = new OleDbCommand("Update ekle Set ADI='" + textBox2.Text + "',SOYADI='" + textBox3.Text + "',GSM='" + masktext_cep.Text + "',DOGUM_YERI='" + combo_dyer.Text + "',D_TARIHI='" + masktext_dt.Text + "',CINSIYET='" + cins+ "',KAN_GRUBU='" + combo_kan.Text + "',MESLEK='" + combo_meslek.Text + "',GUVENCE='" + combo_sgk.Text + "',ADRES='" + textBox5.Text + "'Where TC='" + txt_ara_sil.Text + "'", baglan);
            baglan.Open();
            guncellemem.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Güncelleme başarılı.", "Genel Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sakin_kayit();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Silinecek&Güncellenecek kişinin TC gir")
                textBox1.Text = "";

        }

        public string hastalik = "";
        public string kisi_bilgiler = "";

        private void button4_Click_1(object sender, EventArgs e)
        {
            baglan.Open(); 
            OleDbCommand cmd = new OleDbCommand("Select TC from ekle where TC='" + Convert.ToString(textBox6.Text) + "'", baglan);
            OleDbDataReader oku = null;
            OleDbDataReader oku_analiz = null;
            
            oku = cmd.ExecuteReader(); 
            

            if (oku.Read())
            {
                OleDbCommand kisi_bilgi_sorgu = new OleDbCommand("Select * from ekle where TC='" + Convert.ToString(textBox6.Text)+"'",baglan); 
                OleDbCommand sorgu = new OleDbCommand("Select * from hastaliklar where TC='" + Convert.ToString(textBox6.Text) + "'", baglan);

               

                oku_analiz = sorgu.ExecuteReader(); 

                while (oku_analiz.Read())
                {
                    hastalik = Convert.ToString(oku_analiz.GetBoolean(1)) + "+" + Convert.ToString(oku_analiz.GetBoolean(2)) + "+"
                             + Convert.ToString(oku_analiz.GetBoolean(3)) + "+" + Convert.ToString(oku_analiz.GetBoolean(4)) + "+"
                             + Convert.ToString(oku_analiz.GetBoolean(5)) + "+" + Convert.ToString(oku_analiz.GetBoolean(6)) + "+"
                             + Convert.ToString(oku_analiz.GetBoolean(7)) + "+" + Convert.ToString(oku_analiz.GetBoolean(8)) + "+"
                             + Convert.ToString(oku_analiz.GetBoolean(9)) + "+" + Convert.ToString(oku_analiz.GetBoolean(10)) + "+"
                             + Convert.ToString(oku_analiz.GetBoolean(11)) + "+" + Convert.ToString(oku_analiz.GetBoolean(12)) + "+"
                             + Convert.ToString(oku_analiz.GetBoolean(13)) + "+" + Convert.ToString(oku_analiz.GetBoolean(14)) + "+"
                             + Convert.ToString(oku_analiz.GetBoolean(15));
                }

                oku = kisi_bilgi_sorgu.ExecuteReader();

                while (oku.Read())
                {
                     kisi_bilgiler = oku["TC"].ToString()+ "+" +oku["ADI"].ToString()+ "+" + oku["SOYADI"].ToString()
                                 + "+" + oku["GSM"].ToString() + "+" + oku["DOGUM_YERI"].ToString() + "+" + oku["D_TARIHI"].ToString()
                                 + "+" + oku["CINSIYET"].ToString() + "+" + oku["KAN_GRUBU"].ToString() + "+" + oku["MESLEK"].ToString() 
                                 + "+" + oku["GUVENCE"].ToString() + "+" + oku["ADRES"].ToString() +"+"+oku["RESIM"].ToString();
                } 

                baglan.Close();
                analizform ac = new analizform();
                ac.Cagir(this); 
                ac.Show();
            }


            else {
                baglan.Close();
                MessageBox.Show("Böyle bir kayıt bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public string Gonder2()
        {
            return kisi_bilgiler;

        }
        public string Gonder()
        {
            return hastalik;
        }


      
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = webBrowser1.StatusText;
        }

        private void combo_kan_DrawItem(object sender, DrawItemEventArgs e)
        {
       
        }
        
        public static void resim(string sakin,string aile) {
            System.IO.File.Copy(sakin,aile);
        }

        String yol = "";
        private void btn_resim_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
            }
            else
            {
                yol=openFileDialog1.FileName.ToString();
                pictureBox1.Image = Image.FromFile(yol);
            }
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) { }
            else {
                yol = openFileDialog1.FileName.ToString();
                pictureBox2.Image = Image.FromFile(yol);
            }
        }

        private void btn_git_Click(object sender, EventArgs e)
        {

        }

        private void btn_git_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBox1.Text);
            this.Text= webBrowser1.DocumentTitle.ToString();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            comboBox1.Text = webBrowser1.Url.ToString();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar2.Visible = true;
                toolStripProgressBar2.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar2.Value = Convert.ToInt32(e.CurrentProgress);
            }
            catch { toolStripProgressBar2.Value = 0;
            toolStripProgressBar2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan2.Open();
            OleDbCommand guncelle = new OleDbCommand("select * from ekle_aile where TC='" + Convert.ToString(textBox1.Text) + "'", baglan2);
            OleDbDataReader guncel_oku = null;
            guncel_oku = guncelle.ExecuteReader();


           if (guncel_oku.Read())
            {

                mask_tc2.Enabled = false;
                mask_tc2.Text = Convert.ToString(guncel_oku[0]);
                txt_aile_ad.Text = Convert.ToString(guncel_oku[1]);
                txt_aile_soyad.Text = Convert.ToString(guncel_oku[2]);
                mask_aile_no.Text = Convert.ToString(guncel_oku[3]);
                mask_aile_no2.Text = Convert.ToString(guncel_oku[4]);
                mask.Text = Convert.ToString(guncel_oku[5]);

                string cinsal = Convert.ToString(guncel_oku[6]);
                if (cinsal == "Bay")
                {
                    radioButton4.Checked = true;
                }
                else if (cinsal == "Bayan")
                {
                    radioButton3.Checked = true;

                }
                cinsal = Convert.ToString(guncel_oku[6]);
                com_aile_mes.Text = Convert.ToString(guncel_oku[7]);
                com_aile_sehir.Text = Convert.ToString(guncel_oku[8]);
                txt_aile_adres.Text = Convert.ToString(guncel_oku[9]);
                baglan2.Close();
            }
           
             else
            { MessageBox.Show("Böyle bir kayıt bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error); baglan.Close(); baglan2.Close(); }
               
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/nsarguclu");
        }

        private void label26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ensarguclu.com");
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/nsarguclu");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(" https://plus.google.com/u/0/116602177612757418322/posts");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ensarguclu.blogspot.com/");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("  https://twitter.com/ensarguclu");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tr.linkedin.com/in/nsarguclu");  
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(" http://ensarguclu.kimdir.com/");  
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(" https://login.skype.com");  
        }
    }
}


