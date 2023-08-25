using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ekub.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Reflection;
using Ekub.ViewModels;
using Microsoft.Ajax.Utilities;

namespace Ekub.Controllers
{
    public class FilterController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Filter
        public ActionResult Index()
        {
            return View();
        }
        // accept max money should be collected and max number of people to participate on ekub
        
            public ActionResult CalculateMinimumMoney()
             {

                return View();
              }

        // this is the list that store eligible people its used inside the CalculateMinimumMoneys action
        List<EligiblePart> peopleList = new List<EligiblePart>();
        //accept the max money that should be collected the end of rotation
        public ActionResult CalculateMaximumMoney()
        {
            var eligible = context.eligibles.ToList();
            var member = context.members.ToList();
            var ekub = context.ekub.ToList();

            var viewModel = new List<EligibleLucky>
            {
                new EligibleLucky
                {
                     member = member,
                     ekub = ekub,
                     eligible = eligible,
                }
            };
            return View(viewModel);
        }
        [Authorize]
        public ActionResult CalculateMinimumMoneys(int ? maxs)
        {
            var numberOfPeople = context.members.Count();


          
            var ParticipantList = context.members.Include(i => i.EkubInformation).ToList();


            //double minPercent = (((100.0 / numberOfPeople) / 100.0)/2.0);
            //var TotalMoney = context.ekub.Sum(m => m.ContributionAmount);

            //var MinMoneyNeeded = TotalMoney * minPercent;
            EligiblePart plist;
            foreach (var participant in ParticipantList) 
            {
                var prevWinnerIds = context.round.Select(m => m.Id);
                bool check = prevWinnerIds.Contains(participant.Id);


                if (maxs > 0)
              {  if (!check)
                    {

                        plist = new EligiblePart();
                        plist.Name = participant.Name;
                        plist.Gender = participant.Gender;

                        //plist.TotalAmountContributed = participant.EkubInformation.ContributionAmount;
                        peopleList.Add(plist);
                    }
                     
                }
                else
                {
                   // return Content("no user found");
                }
            }
            if(peopleList.Count > 0)
            {
                context.eligibles.AddRange(peopleList);
                context.SaveChanges();
            }
            return Json(ParticipantList,JsonRequestBehavior.AllowGet);

        }
        [Authorize]
        [HttpGet]
        public ActionResult Selector()
        {
            var eligible = context.eligibles.ToList();
            Random r = new Random();
            IEnumerable<EligiblePart> LuckyMan = eligible.OrderBy(u => r.Next()).Take(1);
            //Debug.WriteLine(LuckyMan);
            Round lucky = new Round();

            foreach (var winners in LuckyMan)
            {
                
                lucky.Name =winners.Name;
                lucky.LuckyManId = winners.Id;
                lucky.Gender = winners.Gender;
                ++lucky.Rounds;
            }
            context.round.Add(lucky);
            context.SaveChanges();
          
           
            return Json(LuckyMan, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Checker()
        {
            Round check = new Round();
            var round = context.round.Select(r => r.Rounds).FirstOrDefault();

            var people = context.members.Count();
            var message = true;
            if (round.Equals(people)){
                 message = true;
            }
            else
            {
                message = false;
            }
            return Json(message,JsonRequestBehavior.AllowGet);
        }
    }
}
