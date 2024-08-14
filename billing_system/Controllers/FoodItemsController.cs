using billing_system.DBContext;
using billing_system.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace billing_system.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FoodItemsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public FoodItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ResponseModel> GetFoodItems()
        {
            try
            {
                var resp = await _context.FoodItems.ToListAsync();
                if (resp == null)
                {
                    return new ResponseModel()
                    {
                        Status = "Success",
                        Message = $"Null Data found",
                        Data = null
                    };
                }
                return new ResponseModel()
                {
                    Status = "Success",
                    Message = $"Data fetched succesfully",
                    Data = resp
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Status = "Failed",
                    Message = $"Failed to fetch data: {ex.Message}",
                    Data = null
                };
            }
        }

        [HttpGet("{id}")]
        public async Task<ResponseModel> GetFoodItemsByFoodCategoryId(int id)
        {
            try
            {
                var resp = await _context.FoodItems.Where(x => x.FoodCategoryId == id).ToListAsync();
                if (resp == null)
                {
                    return new ResponseModel()
                    {
                        Status = "Success",
                        Message = $"Null Data found",
                        Data = null
                    };
                }
                return new ResponseModel()
                {
                    Status = "Success",
                    Message = $"Data fetched Succesfully",
                    Data = resp
                };
            }
            catch (Exception ex) {
                return new ResponseModel
                {
                    Status = "Failed",
                    Message = $"Failed to fetch data: {ex.Message}",
                    Data = null
                };

            }
        }

    }
}
