using CMSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSProject.Data
{
    public class CMSInitializer : System.Data.Entity.DropCreateDatabaseAlways<CMSContext>
    {
        protected override void Seed(CMSContext context)
        {
            var contacts = new List<Contact>
            {
                new Contact{FirstName = "John", LastName = "Lennon", EmailAddress = "john@thebeatles.com", Birthdate = DateTime.Parse("1940-10-09"), NumberOfComputers = 10 },
                new Contact{FirstName = "Paul", LastName = "McCartney", EmailAddress = "paul@thebeatles.com", Birthdate = DateTime.Parse("1942-06-18"), NumberOfComputers = 10 }
            };

            contacts.ForEach(c => context.Contacts.Add(c));
            context.SaveChanges();

            var addresses = new List<Address>
            {
                new Address{ContactID = 1, AddressType=Models.Type.Work, AddressLine1 = "1234 W 42nd Street", AddressLine2 = "Suite 2000", City = "New York", StateCode = "NY", Zip = "10017"},
                new Address{ContactID = 1, AddressType=Models.Type.Home, AddressLine1 = "1601 Sawgrass Corporate Pkwy", AddressLine2 = "", City = "Sunrise", StateCode = "FL", Zip = "33323"},
                new Address{ContactID = 2, AddressType=Models.Type.Work, AddressLine1 = "456 W 42nd Street", AddressLine2 = "Suite 3000", City = "New York", StateCode = "NY", Zip = "10017"},
                new Address{ContactID = 2, AddressType=Models.Type.Mailing, AddressLine1 = "2500 Sawgrass Corporate Parkway", AddressLine2 = "", City = "Sunrise", StateCode = "FL", Zip = "33323"}
            };

            addresses.ForEach(a => context.Addresses.Add(a));
            context.SaveChanges();
        }
    }
}