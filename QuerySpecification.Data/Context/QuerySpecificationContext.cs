using Microsoft.EntityFrameworkCore;
using QuerySpecification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuerySpecification.Data.Context
{
    public class QuerySpecificationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Integrated Security=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
