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

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(String numday)
        {
            label1.Text = numday;

        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {            
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show();
        }
    }
}
