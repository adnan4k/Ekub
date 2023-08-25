using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ekub.Models
{
    public  class EkubInformation
    {
        public int Id { get; set; }
        public string EkubName { get; set; }
        [Range(500, 500, ErrorMessage = "Amount must be 500 Birr.")]
        public int ContributionAmount { get; set; }
        //public int  TotalContribution { get; set; }  
       // public string Cycle { get; set; }
        public DateTime Day { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.Now;
     
    }
}