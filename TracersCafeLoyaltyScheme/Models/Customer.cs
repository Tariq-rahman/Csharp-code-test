using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the Firstname")]
        public String Firstname { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the Lastname")]
        public String Lastname { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the first line of address")]
        public String Adress1 { get; set; }
        public String Adress2 { get; set; }
        public String Adress3 { get; set; }
        public String Adress4 { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the Postcode")]
        public String Postcode { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a Telephone number")]
        public String Telephone { get; set; }
        public int Age { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public DateTime ModifiedDate { get; set; }
    }
}
    