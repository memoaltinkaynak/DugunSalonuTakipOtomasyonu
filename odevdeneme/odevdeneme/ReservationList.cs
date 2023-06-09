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
    public partial class ReservationList : Form
    {
        public ReservationList()
        {
            InitializeComponent();
        }

        static string constring = ("Data Source=DESKTOP-S67J15H\\SQLEXPRESS01;Initial Catalog=duguntakip;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);

        private void button1_Click(object sender, EventArgs e)
        {
            ReservationForm frm = new ReservationForm();
            try
            {
               frm. txtProgramtarih.Text = UserControlDays.static_day + "." + UserControlDays.static_month + "." + AnaEkran.static_year;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            DateTime date = DateTime.Now;
            string dateText = date.ToString("dd.MM.yyyy");
            frm.txtSozlesmeTarih.Text = dateText.ToString();
            frm.btnSave.Visible = true;
            frm.btnDelete.Visible = false;
            frm.btnUpdate.Visible = false;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReservationForm frm = new ReservationForm();

            if (dataGridViewList.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewList.SelectedRows[0].Index;
                frm.id = dataGridViewList.Rows[rowIndex].Cells[0].Value.ToString();
                
                    

                frm.txtProgramtarih.Text = dataGridViewList.Rows[rowIndex].Cells[1].Value.ToString();
                frm.txtBaslama.Text = dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString();
                frm.txtBitis.Text = dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString();
                frm.txtSozlesmeTarih.Text = dataGridViewList.Rows[rowIndex].Cells[4].Value.ToString();
                frm.txtKimlik.Text = dataGridViewList.Rows[rowIndex].Cells[5].Value.ToString();
                frm.txtAdsoyad.Text = dataGridViewList.Rows[rowIndex].Cells[6].Value.ToString();
                frm.txtTel1.Text = dataGridViewList.Rows[rowIndex].Cells[7].Value.ToString();
                frm.txtTel2.Text = dataGridViewList.Rows[rowIndex].Cells[8].Value.ToString();
                frm.comboBox1.Text = dataGridViewList.Rows[rowIndex].Cells[9].Value.ToString();
                frm.txtBilgi.Text = dataGridViewList.Rows[rowIndex].Cells[10].Value.ToString();
                frm.txtYore.Text = dataGridViewList.Rows[rowIndex].Cells[11].Value.ToString();
                frm.txtAdres.Text = dataGridViewList.Rows[rowIndex].Cells[12].Value.ToString();
                frm.txtDavetli.Text = dataGridViewList.Rows[rowIndex].Cells[13].Value.ToString();
                frm.txttoplamucret.Text = dataGridViewList.Rows[rowIndex].Cells[14].Value.ToString();
                frm.txtalinanucret.Text = dataGridViewList.Rows[rowIndex].Cells[15].Value.ToString();
                frm.txtkalanucret.Text = dataGridViewList.Rows[rowIndex].Cells[16].Value.ToString();
                frm.txtAciklama.Text = dataGridViewList.Rows[rowIndex].Cells[17].Value.ToString();
            }


            frm.btnSave.Visible = false;
            frm.btnDelete.Visible = false;
            frm.btnUpdate.Visible = true;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* ReservationForm frm = new ReservationForm();

             if (dataGridViewList.SelectedRows.Count > 0)
             {
                 int rowIndex = dataGridViewList.SelectedRows[0].Index;

                 frm.txtProgramtarih.Text = dataGridViewList.Rows[rowIndex].Cells[1].Value.ToString();
                 frm.txtBaslama.Text = dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString();
                 frm.txtBitis.Text = dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString();
                 frm.txtSozlesmeTarih.Text = dataGridViewList.Rows[rowIndex].Cells[4].Value.ToString();
                 frm.txtKimlik.Text = dataGridViewList.Rows[rowIndex].Cells[5].Value.ToString();
                 frm.txtAdsoyad.Text = dataGridViewList.Rows[rowIndex].Cells[6].Value.ToString();
                 frm.txtTel1.Text = dataGridViewList.Rows[rowIndex].Cells[7].Value.ToString();
                 frm.txtTel2.Text = dataGridViewList.Rows[rowIndex].Cells[8].Value.ToString();
                 frm.comboBox1.Text = dataGridViewList.Rows[rowIndex].Cells[9].Value.ToString();
                 frm.txtBilgi.Text = dataGridViewList.Rows[rowIndex].Cells[10].Value.ToString();
                 frm.txtYore.Text = dataGridViewList.Rows[rowIndex].Cells[11].Value.ToString();
                 frm.txtAdres.Text = dataGridViewList.Rows[rowIndex].Cells[12].Value.ToString();
                 frm.txtDavetli.Text = dataGridViewList.Rows[rowIndex].Cells[13].Value.ToString();
                 frm.txttoplamucret.Text = dataGridViewList.Rows[rowIndex].Cells[14].Value.ToString();
                 frm.txtalinanucret.Text = dataGridViewList.Rows[rowIndex].Cells[15].Value.ToString();
                 frm.txtkalanucret.Text = dataGridViewList.Rows[rowIndex].Cells[16].Value.ToString();
                 frm.txtAciklama.Text = dataGridViewList.Rows[rowIndex].Cells[17].Value.ToString();
             }

             frm.btnSave.Visible = false;
             frm.btnDelete.Visible = true;
             frm.btnUpdate.Visible = false;
             frm.Show();*/

            try {
                if (dataGridViewList.SelectedRows.Count > 0){
                    int rowIndex = dataGridViewList.SelectedRows[0].Index;
                    using (SqlConnection connection = new SqlConnection(constring))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"DELETE FROM rezervasyon_table WHERE rezervasyon_id = {dataGridViewList.Rows[rowIndex].Cells[0].Value}", connection))
                        {
                            command.Parameters.AddWithValue("@id", dataGridViewList.Rows[rowIndex].Cells[0].Value);
                            command.ExecuteNonQuery();
                            reslistele();
                        }
                    }
                } 
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void reslistele()
        {
            string getir = "Select * From rezervasyon_table";

            SqlCommand komut = new SqlCommand(getir, baglan);

            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridViewList.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            reslistele();
        }

        private void ReservationList_Load(object sender, EventArgs e)
        {
           
            reslistele();
           
        }

        
    }
}
