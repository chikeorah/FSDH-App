using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FSDH_App.Models;

namespace FSDH_App.Models
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> scOptions): base(scOptions)
        {
        }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<FSDH_App.Models.Purchase> Purchase { get; set; }
    }
}