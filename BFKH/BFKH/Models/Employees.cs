using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BFKH.Models
{
    public class Employees
    {
        [Key]

        public int id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Start Date")]
        public string Start_Date { get; set; }
        [Display(Name = "End Date")]
        public string End_Date { get; set; }
        public double Wage { get; set; }
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        [Display(Name = "User Name")]
        public string User_Name { get; set; }
        public string Email { get; set; }
    }
}