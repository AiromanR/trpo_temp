using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RestaurantController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Restaurant> restorants = RestaurantService.GetAllRest( );
            return Ok(restorants);
        }
        [HttpGet("{id:int}")]
        public IActionResult Get (int id)
        {
            var restorant = RestaurantService.Get(2);

            return Ok(restorant);
        }
        [HttpPost]
        public IActionResult Create(ProductHeaderValue product)
        {
            return Ok( );
        }
        
    }
}
