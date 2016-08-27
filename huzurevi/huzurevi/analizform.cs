using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;


namespace huzurevi
{
    public partial class analizform : Form
    {
        public analizform()
        {
            InitializeComponent();
        }

        public string hastaliklar = "";
        public string[] hastalikdizisi = new string[15];
        public string kisi_bilgi = "";
        public string[] kisi_dizisi = new string[11];

        private void analizform_Load(object sender, EventArgs e)
        {

        }

        public void Cagir(Form1 ac)
        {

            kisi_bilgi = ac.Gonder2();
            hastaliklar = ac.Gonder();

            for (int j = 0; j < kisi_bilgi.Length; j++)
            {
                kisi_dizisi = kisi_bilgi.Split('+');
            }

            label21.Text = kisi_dizisi[0];
            label5.Text = kisi_dizisi[0];
            label8.Text = kisi_dizisi[1];
            label6.Text = kisi_dizisi[2];
            label4.Text = kisi_dizisi[3];
            label2.Text = kisi_dizisi[4];
            label1.Text = kisi_dizisi[5];
            label25.Text = kisi_dizisi[6];
            label27.Text = kisi_dizisi[7];
            label22.Text = kisi_dizisi[9];
            label28.Text = kisi_dizisi[10]; 
            label33.Text = kisi_dizisi[11];
            pictureBox1.Image = Image.FromFile(kisi_dizisi[12]);
           

            for (int i = 0; i < hastaliklar.Length; i++)
            {
                hastalikdizisi = hastaliklar.Split('+');
            }

            if (hastalikdizisi[0] == "True")
            {
                checkBox1.Checked = true;
            }
            if (hastalikdizisi[1] == "True")
            {
                checkBox2.Checked = true;
            }
            if (hastalikdizisi[2] == "True")
            {
                checkBox3.Checked = true;
            }
            if (hastalikdizisi[3] == "True")
            {
                checkBox4.Checked = true;
            }
            if (hastalikdizisi[4] == "True")
            {
                checkBox5.Checked = true;
            }
            if (hastalikdizisi[5] == "True")
            {
                checkBox6.Checked = true;
            }
            if (hastalikdizisi[6] == "True")
            {
                checkBox7.Checked = true;
            }
            if (hastalikdizisi[7] == "True")
            {
                checkBox8.Checked = true;
            }
            if (hastalikdizisi[8] == "True")
            {
                checkBox9.Checked = true;
            }
            if (hastalikdizisi[9] == "True")
            {
                checkBox10.Checked = true;
            }
            if (hastalikdizisi[10] == "True")
            {
                checkBox11.Checked = true;
            }
            if (hastalikdizisi[11] == "True")
            {
                checkBox12.Checked = true;
            }
            if (hastalikdizisi[12] == "True")
            {
                checkBox13.Checked = true;
            }
            if (hastalikdizisi[13] == "True")
            {
                checkBox14.Checked = true;
            }
            if (hastalikdizisi[14] == "True")
            {
                checkBox15.Checked = true;
            }


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

        }

        private void btn_temiz_Click(object sender, EventArgs e)
        {

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txt_ara_sil_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txt_ara_sil_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_sakin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_sakin_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void masktext_tc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void masktext_cep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void masktext_dt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void combo_sgk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_dyer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_Click(object sender, EventArgs e)
        {

            if (checkBox12.Checked == true)
            {
                checkBox12.Checked = false;
            }
            else
            {
                checkBox12.Checked = true;
            }

        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                checkBox11.Checked = false;
            }
            else
            {
                checkBox11.Checked = true;
            }
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox8.Checked = false;
            }
            else
            {
                checkBox8.Checked = true;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox4.Checked = false;
            }
            else
            {
                checkBox4.Checked = true;
            }
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox5.Checked = false;
            }
            else
            {
                checkBox5.Checked = true;
            }
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox6.Checked = false;
            }
            else
            {
                checkBox6.Checked = true;
            }
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox7.Checked = false;
            }
            else
            {
                checkBox7.Checked = true;
            }
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox9.Checked = false;
            }
            else
            {
                checkBox9.Checked = true;
            }
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBox10.Checked = false;
            }
            else
            {
                checkBox10.Checked = true;
            }
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                checkBox13.Checked = false;
            }
            else
            {
                checkBox13.Checked = true;
            }
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                checkBox14.Checked = false;
            }
            else
            {
                checkBox14.Checked = true;
            }
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                checkBox15.Checked = false;
            }
            else
            {
                checkBox15.Checked = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        Form1 f = new Form1();
        
        yazma_islemi MyDataGridViewPrinter;

        private bool SetupThePrinting(DataGridView data)
        {
            string baslik = "asd";
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = true;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;
            YazdirmaDokumani.DocumentName = baslik;
            YazdirmaDokumani.PrinterSettings =
            MyPrintDialog.PrinterSettings;
            YazdirmaDokumani.DefaultPageSettings =
            MyPrintDialog.PrinterSettings.DefaultPageSettings;
            YazdirmaDokumani.DefaultPageSettings.Margins =
            new Margins(20, 20, 20, 20);
            if (MessageBox.Show("Raporu sayfaya ortalamak ister misiniz?",
            "Rapor Ortalaması", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                MyDataGridViewPrinter = new yazma_islemi(data,
                YazdirmaDokumani, true, true, baslik, new Font("Tahoma", 14,
                FontStyle.Regular, GraphicsUnit.Point), Color.Black, true);
            else
                MyDataGridViewPrinter = new yazma_islemi(data,
                YazdirmaDokumani, false, true, baslik, new Font("Tahoma", 14,
                FontStyle.Regular, GraphicsUnit.Point), Color.Black, true);
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (SetupThePrinting(f.dataGrid_sakin))
            {
                try
                {
                    PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                    MyPrintPreviewDialog.Document = YazdirmaDokumani;
                    MyPrintPreviewDialog.ShowDialog();
                }
                catch (Exception)
                {

                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (SetupThePrinting(f.dataGrid_sakin))
                    YazdirmaDokumani.Print();
            }
            catch (Exception)
            {
                MessageBox.Show("Yazıcınızı Kontrol Ediniz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            excel_islem eis = new excel_islem();
            eis.Dt_ExelAktar(f.dataGrid_sakin);
        }

        private void YazdirmaDokumani_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

    }
}
