using Mvc.TestProject.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Mvc.TestProject.Data
{
   
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<DataContext>(new DropCreateDatabaseAlways<DbContext>());
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}

        public DbSet<Contact> Contact { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
