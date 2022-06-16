using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace AutoVeod_MVC_Toman.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Autoveod-MVC-Toman.Models.Autovedu> Autoveod { get; set; }
    }
}