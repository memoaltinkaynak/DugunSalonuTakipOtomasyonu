using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace odevdeneme
{
    public partial class GirisEkrani : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public GirisEkrani()
        {
            InitializeComponent();
        }
               
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            con = new SqlConnection("Data Source=DESKTOP-S67J15H\\SQLEXPRESS01;Initial Catalog=duguntakip;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From giris_table where kullanici_adi='" + txtUser.Text + "'and sifre='" + txtPassword.Text + "'";
            
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri hatalı!");
                txtUser.Clear();
                txtPassword.Clear();
            }
            con.Close();
            /*
            if (txtKullaniciAdi.Text == "" && txtSifre.Text == ""){
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri hatalı!");
            }
        */
        }

        private void yetkiliGirisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            YetkiliGiris yetkiliGiris = new YetkiliGiris();
            yetkiliGiris.Show();
        }
    }
}
