using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSProject.Models
{ 
    public enum Type {
        Home, Work, Mailing
    }

    public class Address
    {
        public int ID { get; set; }
        public int ContactID { get; set; }
        public Type AddressType { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string Zip { get; set; }
    }
}