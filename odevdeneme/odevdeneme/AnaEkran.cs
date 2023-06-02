using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevdeneme
{
    public partial class AnaEkran : Form


      
    {
        
        public AnaEkran()
        {
            InitializeComponent();
        }
        List<String> ayList = new List<String>() { "OCAK", "ŞUBAT", "MART", "NİSAN", "MAYIS", "HAZİRAN", "TEMMUZ", "AĞUSTOS", "EYLÜL", "EKİM", "KASIM", "ARALIK" };
       
        DateTime now = DateTime.Now;
        int counterYear = 0;
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            FillYearsComboBox();
            textChanged(now.Year);
            ayDoldur();
        }
        // Ay isimlerini yazdırır.
        private void textChanged(int yil)
        {

            ocakText.Text = ayList[0].ToString() + " - " + yil.ToString();
            subatText.Text = ayList[1].ToString() + " - " + yil.ToString();
            martText.Text = ayList[2].ToString() + " - " + yil.ToString();
            nisanText.Text = ayList[3].ToString() + " - " + yil.ToString();
            mayisText.Text = ayList[4].ToString() + " - " + yil.ToString();
            haziranText.Text = ayList[5].ToString() + " - " + yil.ToString();
            temmuzText.Text = ayList[6].ToString() + " - " + yil.ToString();
            agustosText.Text = ayList[7].ToString() + " - " + yil.ToString();
            eylulText.Text = ayList[8].ToString() + " - " + yil.ToString();
            ekimText.Text = ayList[9].ToString() + " - " + yil.ToString();
            kasimText.Text = ayList[10].ToString() + " - " + yil.ToString();
            aralikText.Text = ayList[11].ToString() + " - " + yil.ToString();
        }

        private void FillYearsComboBox()
        {
            int currentYear = DateTime.Now.Year;
            int startYear = currentYear - 0; // Başlangıç yılı
            int endYear = currentYear + 50; // Bitiş yılı

            comboBox1.Items.Clear();


          
            // Yılları ekleyin
            for (int year = startYear; year <= endYear; year++)
            {
                comboBox1.Items.Add(year);
            }
 
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int selectedYear = Convert.ToInt32(comboBox1.SelectedItem);
                int selectIndex = selectedYear - now.Year;
                counterYear = selectIndex;
                int yil = now.Year + counterYear;
                btnDegistir(yil);

            }
        }

        private void ayDoldur()
        {
            int ay = 1;
            ayDegis(ay, ocakPanel);
            ay = 2;
            ayDegis(ay, subatPanel);
            ay = 3;
            ayDegis(ay, martPanel);
            ay = 4;
            ayDegis(ay, nisanPanel);
            ay = 5;
            ayDegis(ay, mayisPanel);
            ay = 6;
            ayDegis(ay, haziranPanel);
            ay = 7;
            ayDegis(ay, temmuzPanel);
            ay = 8;
            ayDegis(ay, agustosPanel);
            ay = 9;
            ayDegis(ay, eylulPanel);
            ay = 10;
            ayDegis(ay, ekimPanel);
            ay = 11;
            ayDegis(ay, kasimPanel);
            ay = 12;
            ayDegis(ay, aralikPanel);
        }



        private void ayDegis(int ay,FlowLayoutPanel panel) {
           
            int dayoftheweek;
            DateTime startofthemonth = new DateTime(now.Year+counterYear, ay, 1); // Ayın başlangıç gününü alıyor.
            // string gun5 = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)startofthemonth.DayOfWeek];
            int days = DateTime.DaysInMonth(now.Year+counterYear, ay);


            // Bu kontrol yapısı ay pazar gününden başladığında pazar gününden itibaren nesne oluşturmasını sağlar.
            if (CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)startofthemonth.DayOfWeek] == "Pazar")
            {
                dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 7;
            }
            else { dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")); }

            //Ay Pazartesiden başlamıyorsa boşlukları ayarlar.
            for (int x = 1; x < dayoftheweek; x++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                panel.Controls.Add(ucBlank);
            }
            //Ayın günlerini sıralar.
            for (int y = 1; y <= days; y++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(y.ToString());
                panel.Controls.Add(ucDays);

            }
        }

        private void clear()
        {
            ocakPanel.Controls.Clear();
            subatPanel.Controls.Clear();
            martPanel.Controls.Clear();
            nisanPanel.Controls.Clear();
            mayisPanel.Controls.Clear();
            haziranPanel.Controls.Clear();
            temmuzPanel.Controls.Clear();
            agustosPanel.Controls.Clear();
            eylulPanel.Controls.Clear();
            ekimPanel.Controls.Clear();
            kasimPanel.Controls.Clear();
            aralikPanel.Controls.Clear();

        }

        private void btnnextyear_Click(object sender, EventArgs e)
        {
            counterYear++;
            int yil = now.Year + counterYear;
            btnDegistir(yil);
        }

        private void btnprevyear_Click(object sender, EventArgs e)
        {
            counterYear--;
            int yil = now.Year + counterYear;
            btnDegistir(yil);
        }

        private void btnDegistir(int yil)
        {
            textChanged(yil);
            clear();
            ayDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Özellik Yakında Hizmetinizde...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Özellik Yakında Hizmetinizde...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Özellik Yakında Hizmetinizde...");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Özellik Yakında Hizmetinizde...");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Özellik Yakında Hizmetinizde...");
        }
    }
}