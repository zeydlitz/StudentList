using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Person
    {
        private String Surname;
        private String Name;
        private String Passport;
        public Adress_c adr;
        private DateTime date;
        public String SURNAME { get { return Surname; } set { Surname = value; } }
        public String NAME { get { return Name; } set { Name = value; } }
        public String PASSPORT { get { return Passport; } set { Passport = value; } }
        public DateTime DATE
        {
            get
            { return this.date; }
            set
            {
                if (value < DateTime.Now) this.date = value;
                else this.date = DateTime.Now;
            }
        }
        public Person()
        {
            this.Passport = null;
            this.Name = " ";
            this.Surname = " ";
            this.Passport = " ";
            this.date = DateTime.Now;
        }
        public Person(String s,String f, String p, DateTime t)
        {
            PASSPORT = p;
            NAME= f;
            SURNAME = s;
            DATE = t;
        }

        public virtual String to_ListItem()
        {
            return this.SURNAME + ", " + this.NAME + ", " + date.ToString("yyyy MMMM dd");
        }
 
    }
    public class Student: Person
    {
        public Adress_c un_adr;
        public String Univer;
        
 
        public Student()
        {
            this.Univer = " ";
        }

        public override String to_ListItem()
        {
            
                String k=base.to_ListItem() + ", " + this.Univer+", "+this.PASSPORT;
                //if(adr!=null) k=k+" "+adr.A1+" "+ adr.A2 + " " + adr.A3;
                //if(un_adr!=null)k=k+ " " + un_adr.A1 + " " + un_adr.A2 + " " + un_adr.A3;
            return k;
        }
    }
  
}
