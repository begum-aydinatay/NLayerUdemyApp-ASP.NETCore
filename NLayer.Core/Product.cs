using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public decimal CategoryId { get; set; }

        // 1 product can have only 1 category
        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
    }
}
