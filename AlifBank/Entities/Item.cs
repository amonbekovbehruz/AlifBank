using AlifBank.Common.Enums;

namespace AlifBank.Entities
{
    public class Item
    {
        public string Id { get; set; }
        
        public string Name { get; set; }

        public string? Description { get; set; }

        public ProductType ProductType { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}