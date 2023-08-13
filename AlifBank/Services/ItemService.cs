using AlifBank.Common.Helper;
using AlifBank.Common.Helpers;
using AlifBank.DTO;
using AlifBank.Entities;

namespace AlifBank.Services
{
    public class ItemService : IItemService
    {
        public string Add(ItemDto.Add model, ref ICollection<Item> items)
        {
            if (model == null) { throw new Exception("Please add some values"); }

            var item = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                PriceToPay = CalculatePercentage.calculatePercentage(model.ProductType, model.LeasingPeriod, model.Price),
                PhoneNumber = model.PhoneNumber,
                ProductType = model.ProductType,
                CreatedDateTime = DateTime.Now,
                LeasingPeriod = model.LeasingPeriod,
            };

            items.Add(item);
            SendSMS.SendDetailsSMS(item);
            return $"Added Successfully" + $"{item.Id}";
        }
    }
}
