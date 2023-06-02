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
    public partial class AcilisEkrani : Form
    {
        public AcilisEkrani()
        {
            InitializeComponent();
            timer1.Start();
        
        }

        int saniye = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            saniye++;   
        if(saniye >= 5)
            {

                timer1.Stop();//timerı durduruyoruz.
                GirisEkrani form2 = new GirisEkrani();
                form2.Show();
                this.Close();
            }

            
        }
    }
}
