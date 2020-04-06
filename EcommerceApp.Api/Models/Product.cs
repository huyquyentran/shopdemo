
namespace EcommerceApp.Api.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Origin { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
