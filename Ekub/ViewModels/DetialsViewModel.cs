using Ekub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ekub.ViewModels
{
    public class DetialsViewModel
    {
        public Members members { get; set; }
        public EkubInformation ekubInfo { get; set; }
        public int ? Total { get; set; }
    }
}