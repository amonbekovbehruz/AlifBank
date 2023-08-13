using AlifBank.DTO;
using AlifBank.Entities;

namespace AlifBank.Services
{
    public interface IItemService
    {
        string Add(ItemDto.Add model, ref ICollection<Item> items);
    }
}
