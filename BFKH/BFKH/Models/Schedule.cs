using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BFKH.Models
{
    public class Schedule
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Title { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Start { get; set; }
        [Required]
        public string End { get; set; }
        public string url { get; set; }

        public bool allDay { get; set; }


    }
}