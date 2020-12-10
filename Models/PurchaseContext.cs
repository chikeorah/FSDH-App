using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace FSDH_App.Models
{
    public class PurchaseContext : DbContext
    {
        public PurchaseContext(DbContextOptions<PurchaseContext> scOptions) : base(scOptions)
        {
        }

        public DbSet<Purchase> Purchases { get; set; }
    }
}
