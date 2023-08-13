using AlifBank.DTO;
using AlifBank.Entities;

namespace AlifBank.Services
{
    public class ItemService
    {
        public string Add(ItemDto.Add model, ref ICollection<Item> items)
        {
            if (model == null) { throw new Exception("Please add some values"); }

            
        }
    }
}
