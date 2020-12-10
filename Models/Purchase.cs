using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDH_App.Models
{
    public class Purchase
    {
        public long Id { get; set; }
        public long StockId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
}
