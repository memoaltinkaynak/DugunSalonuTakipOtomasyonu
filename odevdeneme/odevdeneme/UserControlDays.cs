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
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public static String static_month;
        public UserControlDays()
        {
            InitializeComponent();
           
        }
        private void UserControlDays_Load(object sender, EventArgs e)
        {
        }


        public void days(String numday)
        {
            if(numday.Length == 1)
            {
                label1.Text = "0"+numday;
            }
            else
            {
                label1.Text = numday;
            }
            
        }
        public void months(String ay)
        {
            if (ay.Length == 1)
            {
                label2.Text = "0"+ay.ToString();
            }
            else
            {
                label2.Text = ay.ToString();
            }
            
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = label1.Text; 
            static_month = label2.Text;
            
            /*
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show(); */

            ReservationList reservationList = new ReservationList();
            reservationList.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /* ReservationForm reservationForm = new ReservationForm();
             reservationForm.Show(); */

            ReservationList reservationList = new ReservationList();
            reservationList.Show();
        }


    }
}
