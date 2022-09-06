using EFCoreTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorial
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        
        public DbSet<User> Users { get; set; }

    }
}
