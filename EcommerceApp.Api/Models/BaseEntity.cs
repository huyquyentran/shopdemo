using System;

namespace EcommerceApp.Api.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}