using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Ekub.Models;
using Ekub.ViewModels;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;

namespace Ekub.Controllers
{
    public class EkubController : Controller
    {
      ApplicationDbContext context = new ApplicationDbContext();
        
        // GET: Ekub
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Index()
        {
            var members = context.members.ToList();
            return View(members);

        }
        public ActionResult CreateMembers () 
        { 
            return View();
        }
        [HttpPost]
        public ActionResult CreateMembers(Members members)
        {
            var result = context.ekub.ToList();

            if (ModelState.IsValid)
            {
                context.members.Add(members);
                context.SaveChanges();
            }
             
            
            return RedirectToAction("CreateEkub");
        }

        public ActionResult ListMembers () 
        {
            //var lists  = AllInformation();
            var ListEkub = context.ekub.ToList();
            var listMembers = context.members.ToList();
            var viewModel = new List<ListMemberViewModel>
            {
                new ListMemberViewModel
                {
                     MyMember =listMembers ,
                MyEkub = ListEkub
                }
            };
            
            return View(viewModel);
        }
        public ActionResult CreateEkub()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEkub(EkubInformation ekub) 
        {
            if (ModelState.IsValid)
            {
                context.ekub.Add(ekub);

                context.SaveChanges();
            }
         
            return RedirectToAction("Home");
        }
       [Authorize]
      public ActionResult AllInformation() 
        {
            var ekubInformation = context.ekub.ToList();
            var members = context.members.ToList(); 
            
            var viewModel = new List<EkubMemberViewModel>
            {
                new EkubMemberViewModel
                {
                     Members = members,
                EkubInformation = ekubInformation
                }
               

            };
            return View(viewModel);
        }

        // entering contribution every cycle
        public ActionResult EnterSelectedCycle()
        {
            EkubInformation newest = new EkubInformation();
            return View(newest);
        }
        [HttpPost]
        public ActionResult EnterSelectedCycle(EkubInformation ekub)
        {
            EkubInformation newest = new EkubInformation();
            var searched =  context.ekub.FirstOrDefault( n =>n.EkubName == ekub.EkubName );
            if (searched != null)
            {

               searched.ContributionAmount += ekub.ContributionAmount;
                context.SaveChanges();

            }
            return RedirectToAction("Home");
        }
        // [HttpGet]
        /* public ActionResult Delete()
         {
             return View();
         }*/
        [Authorize]
        public ActionResult Delete(int MembersId,int EkubId)
        {
            if(MembersId!=0) { 
                //var ToBeDeleted = context.members.FirstOrDefault(i=> i.Name == name);
                var ToBeDeleted1 = context.members.FirstOrDefault(i => i.Id == MembersId);
                if ( ToBeDeleted1!=null)
                {
                   // context.members.Remove(ToBeDeleted);
                   context.members.Remove(ToBeDeleted1);
                    context.SaveChanges();
                }
              
 
                if(EkubId!=0) 
                { 
                    var ToBeDeleted = context.ekub.FirstOrDefault(e => e.Id == EkubId);
                    context.ekub.Remove(ToBeDeleted);
                    context.SaveChanges();
                }
               
            }
            
           return RedirectToAction("ListMembers");
        }

        [Authorize]
        public ActionResult Details(int id,int EkubId)
        {
            var ekub = context.ekub.FirstOrDefault( e=>e.Id == EkubId);
            var member = context.members.FirstOrDefault(m=>m.Id ==id);
            var total = context.ekub
    .Where(e => e.Id == id)
    .Select(c => (int?)c.ContributionAmount) // Cast to nullable int
    .Sum(); // Sum nullable ints


            //context.detail.Add( detail );
            //context.SaveChanges ();
            var viewModel = new List<DetialsViewModel>
            {
                new DetialsViewModel
                {
                     members = member,
                     ekubInfo = ekub,
                     Total = total,
                }
            };
            return View(viewModel);
        }
       

    }
}