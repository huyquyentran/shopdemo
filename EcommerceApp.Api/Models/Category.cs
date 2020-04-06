using System.Collections.Generic;

namespace EcommerceApp.Api.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
