using Microsoft.EntityFrameworkCore;
using WebUI.Models;

namespace WebUI.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Summary> Summary { get; set; }
    }
}
