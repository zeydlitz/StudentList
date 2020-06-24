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
            this.Country.Text = this.ad.COUNTRY;
            this.Locality.Text = this.ad.CITY;
            this.Street.Text = this.ad.STREET;

        }

        private void Input_Click(object sender, EventArgs e)
        {
            this.ad.COUNTRY = this.Country.Text;
            this.ad.CITY = this.Locality.Text;
            this.ad.STREET = this.Street.Text;
            this.Close();
        }
    }
}
