using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SakilaCustomers.Models;

namespace SakilaCustomers.Data
{
    public class SakilaCustomersContext : DbContext
    {
        public SakilaCustomersContext (DbContextOptions<SakilaCustomersContext> options)
            : base(options)
        {
        }

        public DbSet<SakilaCustomers.Models.Customer> Customer { get; set; }
    }
}
