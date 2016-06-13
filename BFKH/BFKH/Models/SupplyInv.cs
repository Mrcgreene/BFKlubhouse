using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BFKH.Models
{
    public class SupplyInv
    {
        [Key]
        public int Id { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        [Display(Name = "Purchase Price")]
        public double Price { get; set; }
        public int Quantity { get; set; }

        public int warningLevel = 7;
        public int purchaseLevel = 4;
    }
}