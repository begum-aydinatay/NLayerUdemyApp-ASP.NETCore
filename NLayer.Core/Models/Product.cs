namespace NLayer.Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        // 1 product can have only 1 category
        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
    }
}
