using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMSProject.Models
{
    public class Contact
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Birthdate is required.")]
        public DateTime Birthdate { get; set; }
        [Required(ErrorMessage = "Number of Computers is required. Please, we want to know how techy you are.")]
        public int NumberOfComputers { get; set; }

        //EF6 Lazy Loading
        //This allows the Contacts to be tied to the Addresses
        //The ID of the Contact will be tied to the Addresses by the foreign key ContactID
        public virtual ICollection<Address> Addresses { get; set; }
    }
}