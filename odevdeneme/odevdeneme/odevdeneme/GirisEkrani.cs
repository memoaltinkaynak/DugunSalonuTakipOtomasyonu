using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevdeneme
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" && txtSifre.Text == ""){
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri hatalı!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
