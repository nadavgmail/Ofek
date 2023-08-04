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
    public class CustomerProduct 
    {

        [MaxLength(128)]
        
        public string CustomerProductID { get; set; }

        [MaxLength(128)]
        public string CustomerID { get; set; }

        [MaxLength(128)]
        public string AccountNumber { get; set; }

        [MaxLength(128)]
        public string ProductID { get; set; }
        [DisplayFormat(DataFormatString = "{0:#,##0.000#}", ApplyFormatInEditMode = true)]
        public double? Sum { get; set; }

        
        public string Status { get; set; }

        public DateTime? CreatedDate { get; set; }


    }
}