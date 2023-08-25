using Ekub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ekub.ViewModels
{
    public class EkubMemberViewModel
    {
        public List<Members> Members { get; set; }
        public List<EkubInformation> EkubInformation { get; set; }
    }
}