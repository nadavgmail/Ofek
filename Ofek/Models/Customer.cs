using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Ofek
{
    [Serializable]
    public class Customer
    {
        [MaxLength(128)]
        public string CustomerID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [MaxLength(128)]
        public string FirstName { get; set; }

        [Display(Name = "שם משפחה")]
        public string LastName { get; set; }

        [MaxLength(512)]
        public string City { get; set; }
        [MaxLength(512)]
        public string Street { get; set; }
        [MaxLength(128)]
        public string HouseNumber { get; set; }

        [MaxLength(512)]
        public string PrivateEMail { get; set; }

        [Display(Name = "תאריך לידה")]
        public DateTime? BirthDate { get; set; }



        public Customer()
        {

        }
    
        
    }
}