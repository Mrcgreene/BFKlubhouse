using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BFKH.Models
{
    public class OrderMenu
    {
        [Key]
        public int Id { get; set; }
        public string Dish { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}