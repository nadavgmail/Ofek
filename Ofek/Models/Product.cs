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
    public class Product 
    {

        [MaxLength(128)]
        public string ProductID { get; set; }

        [MaxLength(128)]
        public string FinanceInstitue { get; set; }

        [MaxLength(128)]
        public string ProductType { get; set; }

        [MaxLength(128)]
        public string InvestType { get; set; }

        public DateTime? CreatedDate { get; set; }

    



    }
}