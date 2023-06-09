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

namespace odevdeneme
{
    public partial class YakinProgramlar : Form
    {
        public YakinProgramlar()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=DESKTOP-S67J15H\\SQLEXPRESS01;Initial Catalog=duguntakip;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);
        private void YakinProgramlar_Load(object sender, EventArgs e)
        {
            yakin_tarih_getir();

        }
        private void yakin_tarih_getir()
        {
            try
            {
                DateTime date = DateTime.Now;
                string dateText = date.ToString("dd.MM.yyyy");
                string getir = "Select * From rezervasyon_table where program_tarih=@program_tarih";

                SqlCommand komut = new SqlCommand(getir, baglan);
                komut.Parameters.AddWithValue("@program_tarih", dateText);

                SqlDataAdapter ad = new SqlDataAdapter(komut);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


/*
 * 
 *   DataTable dt = new DataTable();
            DataView dv = dt.DefaultView;
          //  dv.RowFilter = "program_tarih LIKE '" + dateText + "%'";
            dataGridView1.DataSource = dv;
 
            try
            {
                DateTime date = DateTime.Now;
                string dateText = date.ToString("dd.MM.yyyy");

                using (SqlConnection connection = new SqlConnection(constring))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Select * From rezervasyon_table where = {dateText}", connection))
                        {
                        SqlDataAdapter ad = new SqlDataAdapter(command);

                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/