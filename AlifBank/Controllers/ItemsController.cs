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

        public ItemsController(ItemService service)
        {
            Service = service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
        public string AddItem(ItemDto.Add model) {
            Service.Add();
        }


    }
}