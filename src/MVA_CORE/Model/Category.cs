using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVA_CORE.Model
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string DisplayName { get; set; }

        public List<Product> Products { get; set; }
    }
}
