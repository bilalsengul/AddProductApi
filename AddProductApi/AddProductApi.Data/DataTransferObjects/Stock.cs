using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddProductApi
{
    public class Stock
    {
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int StockCount { get; set; }
    }
}
