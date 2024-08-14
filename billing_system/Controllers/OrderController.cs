using billing_system.DBContext;
using billing_system.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace billing_system.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ResponseModel> GetOrders()
        {
            try
            {
                var resp = await _context.Orders.ToListAsync();
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
        public async Task<ResponseModel> GetOrderById(int id)
        {
            try
            {
                var resp = await _context.Orders.FindAsync(id);
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

        [HttpPost]
        public async Task<ResponseModel> PostOrder(OrdersModel order)
        {
            try
            {
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
                var resp = CreatedAtAction(nameof(GetOrderById), new { id = order.OrderId }, order);
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
                    Message = $"Data added Succesfully",
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
    }
}
