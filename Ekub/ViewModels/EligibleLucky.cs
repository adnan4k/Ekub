using Ekub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ekub.ViewModels
{
    public class EligibleLucky
    {
        public List<Members> member { get; set; }
        public List<EkubInformation> ekub { get; set; }
        public List<EligiblePart> eligible { get; set; }
        
    }
}