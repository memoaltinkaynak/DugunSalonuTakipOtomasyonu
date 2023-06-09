using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace odevdeneme
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        static string constring = ("Data Source=DESKTOP-S67J15H\\SQLEXPRESS01;Initial Catalog=duguntakip;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);
        public String id;
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            
            baglan.Open();
            

        }

 



        private void txtBaslama_TextChanged(object sender, EventArgs e)
        {
            string girilenSayi = txtBaslama.Text;

            if (girilenSayi.Length == 4)
            {
                if ((girilenSayi[0] == '2' && girilenSayi[1] <= '4') || (girilenSayi[0] <= '1' && girilenSayi[1] <= '9') && (girilenSayi[2] <= '5' && girilenSayi[3] <= '9')) 
                { 
                string formatliSayi = $"{girilenSayi.Substring(0, 2)}:{girilenSayi.Substring(2, 2)}";
                txtBaslama.Text = formatliSayi;
                }
                else
                {
                    MessageBox.Show("Lütfen girilen saati kontrol ediniz!");
                }
            }
            

        }

        private void txtBitis_TextChanged(object sender, EventArgs e)
        {
            string girilenSayi0 = txtBitis.Text;

            if (girilenSayi0.Length == 4)
            {
                if ((girilenSayi0[0] == '2' && girilenSayi0[1] <= '4') || (girilenSayi0[0] <= '1' && girilenSayi0[1] <= '9') && (girilenSayi0[2] <= '5' && girilenSayi0[3] <= '9'))
                {
                    string formatliSayi0 = $"{girilenSayi0.Substring(0, 2)}:{girilenSayi0.Substring(2, 2)}";
                    txtBitis.Text = formatliSayi0;
                }
                else
                {
                    MessageBox.Show("Lütfen girilen saati kontrol ediniz!");
                }
            }
        }

        private void txttoplamucret_TextChanged(object sender, EventArgs e)
        {
            HesaplaToplam();
        }

        private void txtalinanucret_TextChanged(object sender, EventArgs e)
        {
            HesaplaToplam();
        }
        private void HesaplaToplam()
        {

            if (int.TryParse(txttoplamucret.Text, out int sayi1) && int.TryParse(txtalinanucret.Text, out int sayi2))
            {
                int toplam = sayi1 - sayi2;
                txtkalanucret.Text = toplam.ToString();
            }
            else
            {
                txtkalanucret.Text = "Hatalı giriş";
            }            
        }

        private void txtBaslama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBitis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }       

        private void txtTel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttoplamucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtalinanucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDavetli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //SQL
        

        public void reskaydet()
        {            
            try
            {
                string kayit = "insert into rezervasyon_table " +
                    "(program_tarih, baslama_saat, bitis_saat, sozlesme_tarih, tc_no, adi_soyadi, tel_no_1, tel_no_2, program_turu, bilgi, yore_soyisimler, adres, davetli_sayisi, toplam_ucret, alinan_ucret, kalan_ucret, aciklama)" +
                    "values(@programtarih, @baslamasaat, @bitissaat, @sozlesmetarih, @tcno, @adisoyadi, @telno1, @telno2, @programturu, @bilgi, @yoresoyisimler, @adres, @davetlisayisi, @toplamucret, @alinanucret, @kalanucret, @aciklama)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@programtarih", txtProgramtarih.Text.ToString());
                komut.Parameters.AddWithValue("@baslamasaat", txtBaslama.Text.ToString());
                komut.Parameters.AddWithValue("@bitissaat", txtBitis.Text.ToString());
                komut.Parameters.AddWithValue("@sozlesmetarih", txtSozlesmeTarih.Text.ToString());
                komut.Parameters.AddWithValue("@tcno", txtKimlik.Text.ToString());
                komut.Parameters.AddWithValue("@adisoyadi", txtAdsoyad.Text.ToString());
                komut.Parameters.AddWithValue("@telno1", txtTel1.Text.ToString());
                komut.Parameters.AddWithValue("@telno2", txtTel2.Text.ToString());
                komut.Parameters.AddWithValue("@programturu", comboBox1.Text.ToString());
                komut.Parameters.AddWithValue("@bilgi", txtBilgi.Text.ToString());
                komut.Parameters.AddWithValue("@yoresoyisimler", txtYore.Text.ToString());
                komut.Parameters.AddWithValue("@adres", txtAdres.Text.ToString());
                komut.Parameters.AddWithValue("@davetlisayisi", txtDavetli.Text.ToString());
                komut.Parameters.AddWithValue("@toplamucret", txttoplamucret.Text.ToString());
                komut.Parameters.AddWithValue("@alinanucret", txtalinanucret.Text.ToString());
                komut.Parameters.AddWithValue("@kalanucret", txtkalanucret.Text.ToString());
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text.ToString());

                komut.ExecuteNonQuery();
           

                MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Başarılı", MessageBoxButtons.OK);

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var!!" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        int i = 0;
        public void resguncelle()
        {


            ReservationList reservationList = new ReservationList();

           string kayitguncelle =( "UPDATE rezervasyon_table SET " +
                                    "program_tarih = @programtarih, " +
                                    "baslama_saat = @baslamasaat, " +
                                    "bitis_saat = @bitissaat, " +
                                    "sozlesme_tarih = @sozlesmetarih, " +
                                    "tc_no = @tcno, " +
                                    "adi_soyadi = @adisoyadi, " +
                                    "tel_no_1 = @telno1, " +
                                    "tel_no_2 = @telno2, " +
                                    "program_turu = @programturu, " +
                                    "bilgi = @bilgi, " +
                                    "yore_soyisimler = @yoresoyisimler, " +
                                    "adres = @adres, " +
                                    "davetli_sayisi = @davetlisayisi, " +
                                    "toplam_ucret = @toplamucret, " +
                                    "alinan_ucret = @alinanucret, " +
                                    "kalan_ucret = @kalanucret, " +
                                    "aciklama = @aciklama " +
                                    $"WHERE rezervasyon_id = {id}");
             SqlCommand komut = new SqlCommand(kayitguncelle, baglan);
             komut.Parameters.AddWithValue("@programtarih", txtProgramtarih.Text.ToString());
             komut.Parameters.AddWithValue("@baslamasaat", txtBaslama.Text.ToString());
             komut.Parameters.AddWithValue("@bitissaat", txtBitis.Text.ToString());
             komut.Parameters.AddWithValue("@sozlesmetarih", txtSozlesmeTarih.Text.ToString());
             komut.Parameters.AddWithValue("@tcno", txtKimlik.Text.ToString());
             komut.Parameters.AddWithValue("@adisoyadi", txtAdsoyad.Text.ToString());
             komut.Parameters.AddWithValue("@telno1", txtTel1.Text.ToString());
             komut.Parameters.AddWithValue("@telno2", txtTel2.Text.ToString());
             komut.Parameters.AddWithValue("@programturu", comboBox1.Text.ToString());
             komut.Parameters.AddWithValue("@bilgi", txtBilgi.Text.ToString());
             komut.Parameters.AddWithValue("@yoresoyisimler", txtYore.Text.ToString());
             komut.Parameters.AddWithValue("@adres", txtAdres.Text.ToString());
             komut.Parameters.AddWithValue("@davetlisayisi", txtDavetli.Text.ToString());
             komut.Parameters.AddWithValue("@toplamucret", txttoplamucret.Text.ToString());
             komut.Parameters.AddWithValue("@alinanucret", txtalinanucret.Text.ToString());
             komut.Parameters.AddWithValue("@kalanucret", txtkalanucret.Text.ToString());
             komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text.ToString());
             komut.Parameters.AddWithValue("@id", id);
             komut.ExecuteNonQuery();
          



           
             MessageBox.Show("Kayıtlar başarıyla güncellendi.");
        }


        public void ressil(String id)
        {
           
             string sil = ($"Delete From rezervasyon_table  Where rezervasyon_id = {id}");
              SqlCommand komut = new SqlCommand(sil, baglan);

             komut.Parameters.AddWithValue("@id", id);

              komut.ExecuteNonQuery();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Formu kapatmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Evet'e tıklandığında uygulamayı kapat
                this.Close();
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            reskaydet();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            resguncelle();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                ressil(id);
   
        }

        private void txtSozlesmeTarih_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
