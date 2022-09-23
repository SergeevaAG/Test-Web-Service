using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TestWebService.Models;

namespace TestWebService.Controllers
{
    [ApiController]
    [Route("GET")]
    public class GETController : ControllerBase
    {
        [HttpGet("currencies")]
        public IEnumerable<Currency> currencies([FromQuery] PaginationParams @params)
        {
            IEnumerable<Currency> _currencies = InfoGet.Get().Skip((@params.Page - 1) * @params.ItemsPerPage).Take(@params.ItemsPerPage);
            var paginationMetadata = new PaginationMetadata(@params.Page, InfoGet.Get().Count, @params.ItemsPerPage);
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetadata));
            return _currencies;
        }

        [HttpGet("currency/{currencyCode}")]
        public Currency currency([FromRoute] string currencyCode)
        {
            Currency result = new Currency();

            foreach(Currency cur in InfoGet.Get())
            {
                if (cur.CharCode.ToLower() == currencyCode.ToLower()) result = cur;
            }

            return result;
        }
    }
}