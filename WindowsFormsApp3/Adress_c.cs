using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Adress_c
    {
        private String a1;
        private String a2;
        private String a3;
        public String A1
        {
            get { return a1; }
            set { a1 = value; }
        }
        public String A2 {
            get { return a2; }
            set { a2 = value; }
        }
        public String A3
        {
            get { return a3; }
            set { a3 = value; }
        }

        public Adress_c()
        {
            a1 = "";
            a2 = "";
            a3 = "";
        }

        public Adress_c(String a1,String a2,String a3)
        {
            A1 = a1;
            A2 = a2;
            A3 = a3;
        }

    }
}
