using Mango.Services.CouponAPi.Model;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base (options)
        {
            
        }
        public DbSet<Coupon> Coupons { get; set; }


    }
}
