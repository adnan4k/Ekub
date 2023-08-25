using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ekub.Models
{
    public class Round
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Rounds { get; set; }  
        public int ? LuckyManId { get; set; }

    }
}