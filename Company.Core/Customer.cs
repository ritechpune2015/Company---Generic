using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core
{
    [Table("CustomerTbl")]
    public class Customer
    {
        [Key]
        public Int64 CustomerID { get; set; }
        public string CustomeName { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public decimal CreditLimit { get; set; }
    }
}
