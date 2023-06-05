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
    public partial class YetkiliGiris : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public YetkiliGiris()
        {
            InitializeComponent();
        }

        private void yetkiliBackbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
        }

        private void yetkiliGirisBtn_Click(object sender, EventArgs e)
        {
            string user = txtYetkiliUser.Text;
            string password = txtYetkiliPassword.Text;

            con = new SqlConnection("Data Source=DESKTOP-S67J15H\\SQLEXPRESS01;Initial Catalog=duguntakip;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From yetkili_giris where yetkili_kullanici='" + txtYetkiliUser.Text + "'and yetkili_sifre='" + txtYetkiliPassword.Text + "'";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                YetkiliEkran yetkiliEkran = new YetkiliEkran();
                yetkiliEkran.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Admin değilsen zorlama aslan parçası.");
                txtYetkiliUser.Clear();
                txtYetkiliPassword.Clear();
            }
            con.Close();
        }
    }
}
