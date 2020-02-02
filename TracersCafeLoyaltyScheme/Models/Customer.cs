using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TracersCafeLoyaltyScheme.Models
{
    public enum Title
    {
        Mr,Mrs,Ms,Miss
    }
    public class Customer
    {
        public int ID { get; set; }
        public Title Title { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String[] Adress;
        public String Postcode { get; set; }
        public String Telephone { get; set; }
        public int Age { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
    