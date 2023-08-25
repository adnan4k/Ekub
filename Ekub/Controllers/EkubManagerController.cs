using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ekub.Models;

namespace Ekub.Controllers
{
    public class EkubManagerController : Controller
    { 
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: EkubManager
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DeleteMembers(int? id)
        {
            if (id != null)
            {
                var member = context.members.FirstOrDefault(m => m.Id == id);
                return View(member);
            }
           return Content("Error");
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteMembersConfirmed(int id) 
        { 
            if (id != 0)
            {
                var member = context.members.Where(m => m.Id == id).FirstOrDefault();
            }
            return View();
        }

        public ActionResult Dashboard() 
        {
            return View();
        }
    }
}