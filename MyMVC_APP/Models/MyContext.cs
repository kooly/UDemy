using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMVC_APP.Models
{
    public class MyContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MemberShipType> MemberShipTypes { get; set; }
    }
}