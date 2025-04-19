using DotNetCore_Angular_SocialMedia_App.Entities;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace DotNetCore_Angular_SocialMedia_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Batteries.Init();

        }
        public DbSet<AppUser> Users { get; set; } = null!;
       
    }
}
