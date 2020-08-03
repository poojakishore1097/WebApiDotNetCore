using Microsoft.EntityFrameworkCore;

namespace dotnetcorewebapi.Models
{
    public class DotNetCoreWebapiContext : DbContext
    {
        public DotNetCoreWebapiContext(DbContextOptions<DotNetCoreWebapiContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}