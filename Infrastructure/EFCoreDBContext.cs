using Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class EFCoreDBContext: DbContext
    {
        public EFCoreDBContext(DbContextOptions<EFCoreDBContext> options) : base(options)
        {
        }  
        
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=EFCore;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=sa.sa;Trust Server Certificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
