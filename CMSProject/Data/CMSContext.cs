using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CMSProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CMSProject.Data
{
    public class CMSContext : DbContext
    {
        public CMSContext() : base("DefaultConnection") { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}