using CustomerCRM.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCRM.Infrastructure.Data
{
    public class CustomerDbContext: DbContext
    {
        //We are passing it to the base. 
        //base means we are calling the base class constructor.
        //base class: DbContext and DbConext has a constructor which taking DbContextOptions,so we
        // are passing that value to our current class(CustomerDbContext)
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options):base(options)
        {

        }

        public DbSet<Region> Region { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
