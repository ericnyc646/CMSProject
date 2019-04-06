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
using Type = CMSProject.Models.Type;

namespace CMSProject.Controllers
{
    public class ContactSummaryController : Controller
    {

        private CMSContext db = new CMSContext();


        // GET: ContactSummary
        public ActionResult Index()
        {
            var mydatamodel = new Summary();

            mydatamodel.Contacts = from c in db.Contacts
                                   select c;

            var addresstypes = from t in db.Addresses
                               group t by t.AddressType into addtypegroup
                               select new
                               {
                                   Type = addtypegroup.Key,
                                   Count = addtypegroup.Count()
                               };

            mydatamodel.AddressTypeNumbers = new List<AddressTypeNumbers>();

            foreach (var typeitem in addresstypes)
            {
                mydatamodel.AddressTypeNumbers.Add(new AddressTypeNumbers {
                    TypeName = typeitem.Type.ToString(),
                    TypeCount = typeitem.Count

                });
            }

            mydatamodel.TotalComputerCount = (from contacts in db.Contacts
                                              select contacts.NumberOfComputers).Sum();

            return View(mydatamodel);
        }
    }
}