using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSProject.Models
{
    public class Summary
    {
        public IQueryable<Contact> Contacts { get; set; }

        public ICollection<AddressTypeNumbers> AddressTypeNumbers { get; set; }

        public int TotalComputerCount { get; set; }


    }

    public class AddressTypeNumbers
    {
        public string TypeName { get; set; }
        public int TypeCount { get; set; }

    }
}