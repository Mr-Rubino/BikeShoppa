using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShoppa.Model
{
    class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public CustomerGender gender { get; set; }

        public int id { get; set; }
        public int height { get; set; }
        public string email { get; set; }

        public enum CustomerGender
        {
            Male,
            Female
        }

    }


}
