using Microsoft.AspNetCore.Mvc;
using EasyGroceries.API.Repositories;
using EasyGroceries.API.Models;

namespace EasyGroceries.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroceriesController : ControllerBase
    {
        private readonly IGroceryRepository _groceryRepo;

        public GroceriesController(IGroceryRepository groceryRepo)
        {
            _groceryRepo = groceryRepo;
        }

        [HttpGet]
        public ActionResult<List<GroceryItem>> Get()
        {
            return Ok(_groceryRepo.GetAll());
        }
    }
}