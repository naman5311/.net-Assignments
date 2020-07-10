using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HandsOnCRUDAssignment.Entities
{
    public class CustomerContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-HUQT5M5;Initial Catalog=CustomerDB;Integrated Security=True");
        }
    }
}
