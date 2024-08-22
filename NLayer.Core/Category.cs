using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class Category:BaseEntity
    {
        public string Name { get; set; } // because it's a reference type

        // navigation property
        // 1 category can have many products under itself

        public ICollection<Product> Products { get; set; }
    }
}
