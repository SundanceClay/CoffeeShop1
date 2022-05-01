using Microsoft.EntityFrameworkCore;
using CoffeeShopRegistrationLab.Models;

namespace CoffeeShopRegistrationLab.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
