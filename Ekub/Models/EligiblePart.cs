using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ekub.Models
{
    public class EligiblePart
    {
       
        public int Id { get; set; }
        public String Name { get; set; }
        public int TotalAmountContributed { get; set; }
        public String Gender { get; set; }


    }
}