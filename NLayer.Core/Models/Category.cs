namespace NLayer.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } // because it's a reference type

        // navigation property
        // 1 category can have many products under itself

        public ICollection<Product> Products { get; set; }
    }
}
