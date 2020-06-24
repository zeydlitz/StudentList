using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Adress_c
    {
        private String Country;
        private String City;
        private String Street;
        public String COUNTRY
        {
            get { return Country; }
            set { Country = value; }
        }
        public String CITY {
            get { return City; }
            set { City = value; }
        }
        public String STREET
        {
            get { return Street; }
            set { Street = value; }
        }

        public Adress_c()
        {
            Country = "";
            City = "";
            Street = "";
        }

        public Adress_c(String country,String city,String street)
        {
            COUNTRY = country;
            CITY = city;
            STREET = street;
        }

    }
}
