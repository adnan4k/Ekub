using Ekub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ekub.ViewModels
{
    public class ListMemberViewModel
    {
        public List<Members> MyMember { get; set; }
        public List<EkubInformation> MyEkub { get; set; }
       
    }
}