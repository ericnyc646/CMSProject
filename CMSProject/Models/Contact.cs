using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSProject.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime Birthdate { get; set; }
        public int NumberOfComputers { get; set; }

        //EF6 Lazy Loading
        //This allows the Contacts to be tied to the Addresses
        //The ID of the Contact will be tied to the Addresses by the foreign key ContactID
        public virtual ICollection<Address> Addresses { get; set; }
    }
}