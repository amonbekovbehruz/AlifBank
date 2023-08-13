using AlifBank.DTO;
using AlifBank.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AlifBank.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ICollection<Item> Items = new List<Item>();

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
        public string AddItem(ItemDto.Add model) {
            return "Hello World";
        }
    }
}