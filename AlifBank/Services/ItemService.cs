using AlifBank.DTO;
using AlifBank.Entities;

namespace AlifBank.Services
{
    public class ItemService
    {
        public void Add(ItemDto.Add model, ref ICollection<Item> items)
        {
            if (model == null) { throw new Exception("Please add some values"); }


        }
    }
}
