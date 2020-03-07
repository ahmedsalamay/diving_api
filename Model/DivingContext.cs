using Microsoft.EntityFrameworkCore;

namespace diving_api.Model
{
    public class DivingContext : DbContext
    {
        public DivingContext(DbContextOptions<DivingContext> options)
           : base(options)
        {
        }
       public DbSet<User> ro01 { set; get; }
    }
}