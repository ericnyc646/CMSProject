using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CMSProject.Data;
using CMSProject.Models;

namespace CMSProject.Controllers
{
    public class SearchController : Controller
    {
        private CMSContext db = new CMSContext();

        // GET: Search
        public ActionResult Index(string searchString)
        {
            var contacts = from s in db.Contacts
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.LastName.Contains(searchString) || s.FirstName.Contains(searchString));
            }
                        
            return View(contacts.ToList());
        }
    }
}