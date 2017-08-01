using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;
using System;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/formNewJob")]
        public ActionResult formNewJob()
        {
            return View();
        }

        [HttpGet("/jobs")]
        public ActionResult viewJobs()
        {
            return View("jobs", JobOpening.GetAllJobs());
        }

        [HttpPost("/jobs")]
        public ActionResult jobs()
        {

            Contact myContact = new Contact();
            myContact.SetName(Request.Form["name"]);
            myContact.SetPhone(Request.Form["phone"]);
            myContact.SetEmail(Request.Form["email"]);

            string title = (Request.Form["title"]);
            string description = (Request.Form["description"]);
            JobOpening myJob = new JobOpening(title,description,myContact);

            return View(JobOpening.GetAllJobs());
        }

        [HttpGet("/jobs/{number}")]
        public ActionResult JobDetail(int number)
        {
            JobOpening myJob = JobOpening.Find(number);
            return View(myJob);
        }
    }
}
