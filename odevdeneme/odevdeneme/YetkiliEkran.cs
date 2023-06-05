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

        public void kayitlari_getir()
        {
            baglan.Open();
            string getir = "Select * From giris_table";

            SqlCommand komut = new SqlCommand(getir, baglan);

            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "insert into giris_table (kullanici_adi, sifre)values(@kullaniciadi,@sifre)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text.ToString());
                    komut.Parameters.AddWithValue("@sifre", txtSifre.Text.ToString());

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.");
                    baglan.Close();
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bir Hata Var!!" + hata.Message);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            kayitlari_getir();
        }
    }
}
