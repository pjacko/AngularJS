using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJS.Models;

namespace AngularJS.Controllers
{
    public class EventController : Controller
    {
        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public JsonResult Get(int id)
        {
            var sessions = new List<Session>();
            sessions.Add(new Session
                         {
                             name = "Directives Masterclass",
                             creatorName = "Bob Smith",
                             duration = 1,
                             level = "Advanced",
                             description = "In this sesison you will learn the ins and outs of directives!",
                             upVoteCount = 0
                         });

            sessions.Add(new Session
            {
                name = "Scopes for fun and profit",
                creatorName = "John Doe",
                duration = 2,
                level = "Introductory",
                description = "This session will take a closer look at scopes.  Learn what they do, how they do it, and how to get them to do it for you.",
                upVoteCount = 3
            });

            sessions.Add(new Session
            {
                name = "Well Behaved Controllers",
                creatorName = "Jane Doe",
                duration = 4,
                level = "Intermediate",
                description = "Controllers are the beginning of everything Angular does.  Learn how to craft controllers that will win the respect of your friends and neighbors.",
                upVoteCount = 0
            });

            var anEvent = new Event
                          {
                              name = "Angular Boot Camp",
                              date = "1/1/2013",
                              time = "10:30 am",
                              location = new Location
                                         {
                                             address = "Google Headquarters",
                                             city = "Mountain View",
                                             province = "CA"
                                         },
                              imageUrl = "/Content/Images/angularjs-logo.png",
                              sessions = sessions
                          };

            return Json(anEvent, JsonRequestBehavior.AllowGet);
        }
    }
}