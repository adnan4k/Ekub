using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ekub.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }   
       public int ? EkubInfromationId { get; set; }
       
       public EkubInformation EkubInformation { get; set; }
      
    }
}