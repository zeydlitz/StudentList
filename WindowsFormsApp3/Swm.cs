using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class Swm : Form
    {
        public Int16 errorcode;
        Student student;
        public Swm()
        {
            InitializeComponent();
            this.student = new Student();
        }
        public Swm(Student s)
        {
            InitializeComponent();
            this.student = s;
            this.errorcode = 0;
            this.BD.Text = this.student.DATE.ToString("d");
            this.Surname.Text=this.student.SURNAME;
            this.FirstName.Text = this.student.NAME;
            this.Pass.Text = this.student.PASSPORT;
            this.University.Text = this.student.Univer;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Swm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch(MessageBox.Show("Finish work?", "Finishing work", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    e.Cancel = false;
                    this.errorcode = 3;
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;


            }
        }

        public virtual void button1_Click(object sender, EventArgs e)
        {
            this.student.SURNAME = this.Surname.Text;
            this.student.NAME = this.FirstName.Text;
            this.student.PASSPORT = this.Pass.Text;
            this.student.Univer = this.University.Text;
            this.errorcode = 0;
            if(DateTime.TryParse(this.BD.Text,out DateTime d))
            {
                
                this.student.DATE = d;
                if (d > DateTime.Now)
                {
                    MessageBox.Show("Date upper than current date","Opps",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Format of BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.errorcode = 1;
            }

        }

   


        private void Adress_Click(object sender, EventArgs e)
        {
            if (this.student.adr == null) this.student.adr=new Adress_c();
            Adress form=new Adress(this.student.adr);
            form.Text = "Домашний адрес";
            form.ShowDialog();
        }

        private void un_address_Click(object sender, EventArgs e)
        {
            if (this.student.un_adr == null) this.student.un_adr = new Adress_c();
            Adress form = new Adress(this.student.un_adr);
            form.Text = "Адрес университета";
            form.ShowDialog();

        }


    }
}


