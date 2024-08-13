using billing_system.Models;
using Microsoft.EntityFrameworkCore;
namespace billing_system.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DiningTablesModel> DiningTables { get; set; }
        public DbSet<FoodCategoriesModel> FoodCategories { get; set; }
        public DbSet<FoodItemsModel> FoodItems { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
        public DbSet<PayementMethodsModel> PayementMethods { get; set; }
    }
}
