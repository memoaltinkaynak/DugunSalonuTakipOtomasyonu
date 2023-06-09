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

namespace odevdeneme
{
    public partial class YetkiliEkran : Form
    {
        public YetkiliEkran()
        {
            InitializeComponent();
        }
            static string constring = ("Data Source=DESKTOP-S67J15H\\SQLEXPRESS01;Initial Catalog=duguntakip;Integrated Security=True");
            SqlConnection baglan = new SqlConnection(constring);
        
            private void YetkiliEkran_Load(object sender, EventArgs e)
            {
                baglan.Open();
            kayitlari_getir();
            }

        public void verikaydet()
        {
            try
            {
                string kayit = "insert into giris_table (kullanici_adi, sifre)values(@kullaniciadi,@sifre)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text.ToString());
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text.ToString());

                komut.ExecuteNonQuery();
                kayitlari_getir();

                MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var!!" + hata.Message);
            }
        }
        public void kayitlari_getir()
        {
            string getir = "Select * From giris_table";

            SqlCommand komut = new SqlCommand(getir, baglan);

            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            
           
        }

        public void verisil(int id)
        {
            string sil = "Delete From giris_table  Where giris_id = @id";
            SqlCommand komut = new SqlCommand(sil, baglan);

            komut.Parameters.AddWithValue("@id", id);

            komut.ExecuteNonQuery();
        }

        int i = 0;
        public void veriguncelle()
        {
            string kayitguncelle = ("Update giris_table set kullanici_adi = @kad, sifre = @sifre Where giris_id = @id");
            SqlCommand komut = new SqlCommand(kayitguncelle, baglan);
            komut.Parameters.AddWithValue("@kad", txtKullaniciAdi.Text.ToString());
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text.ToString());
            komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[0].Value);

            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıtlar başarıyla güncellendi.");

            kayitlari_getir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            verikaydet();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            kayitlari_getir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil(id);
                kayitlari_getir();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            veriguncelle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            txtKullaniciAdi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void btnDongiris_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
        }

        private void btnAnaekrangit_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();                                                                                                        
        }
    }
}
