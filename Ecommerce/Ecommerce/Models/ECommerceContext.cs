using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {

        }

        public DbSet<Ecommerce.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<Ecommerce.Models.City> Cities { get; set; }
    }
}