using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Adress : Form
    {
        private Adress_c ad;
        public Adress()
        {
            InitializeComponent();
            ad=new Adress_c();
        }

        public Adress(Adress_c ad)
        {
            InitializeComponent();
            this.ad = ad;
            this.Country.Text = this.ad.A1;
            this.Locality.Text = this.ad.A2;
            this.Street.Text = this.ad.A3;

        }

        private void Input_Click(object sender, EventArgs e)
        {
            this.ad.A1 = this.Country.Text;
            this.ad.A2 = this.Locality.Text;
            this.ad.A3 = this.Street.Text;
            this.Close();
        }
    }
}
