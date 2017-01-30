using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVA_CORE.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string DisplayName { get; set; }
        public decimal MSRP { get; set; }
        public decimal CurrentPrice { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
