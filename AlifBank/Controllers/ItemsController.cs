using AlifBank.DTO;
using AlifBank.Entities;
using AlifBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlifBank.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private ItemService Service { get; }

        private ICollection<Item> Items = new List<Item>();

        public ItemsController(IItemService service)
        {
            Service = (ItemService) service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
        public string AddItem(ItemDto.Add model) {
            return Service.Add(model, ref Items);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ICollection<ItemDto.Get>), StatusCodes.Status204NoContent)]
        public ICollection<ItemDto.Get> List()
        {
            ICollection<ItemDto.Get> result = new List<ItemDto.Get>();

            foreach (var item in Items) {
                result.Add(
                    new ItemDto.Get
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Description = item.Description,
                        PhoneNumber = item.PhoneNumber,
                        Price = item.Price,
                        PriceToPay = item.PriceToPay,
                        LeasingPeriod = item.LeasingPeriod,
                        ProductType = item.ProductType
                    });
            }

            return result;
        }
    }
}