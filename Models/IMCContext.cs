using Microsoft.EntityFrameworkCore;

namespace IMC.Models
{
    public class IMCContext : DbContext
    {
        public IMCContext(DbContextOptions<IMCContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}