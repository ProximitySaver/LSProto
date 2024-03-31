using Microsoft.EntityFrameworkCore;

namespace LinguoSphèreProt.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Langage> Langages { get; set; }
        public DbSet<Niveau> Niveaux { get; set; }

    }
}
