using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShoppa.Model
{
    class Reservation
    {
        public Customer customer { get; set; }

        public List<Bike> Bikes { get; set; }

        public Date start { get; set; }
        public Date end { get; set; }

        public Store pickupStore { get; set; }
        public Store dropoffStore { get; set; }
    }
}
