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
        public void SeedData()
        {
            var sampleNiveaux = TestData.GenerateNiveaux();

            var existingNiveauNames = new HashSet<string>(Niveaux.Select(b => b.Nom));

            foreach(var niveau in sampleNiveaux)
            {
                if (!existingNiveauNames.Contains(niveau.Nom))
                {
                    Niveaux.Add(niveau);
                }
            }

            var sampleLangages = TestData.GenerateLangages();

            var existingLangageNames = new HashSet<string>(Langages.Select(b => b.Nom));

            foreach (var langage in sampleLangages)
            {
                if (!existingNiveauNames.Contains(langage.Nom))
                {
                    Langages.Add(langage);
                }
            }

            var sampleFeatures = TestData.GenerateFeatures();

            var existingFeatureNames = new HashSet<string>(Features.Select(b => b.Nom));

            foreach (var feature in sampleFeatures)
            {
                if (!existingFeatureNames.Contains(feature.Nom))
                {
                    Features.Add(feature);
                }
            }

            var sampleCourses = TestData.GenerateCourses(Features.ToList(),Niveaux.ToList(),Langages.ToList());

            var existingCourseNumbers = new HashSet<string>(Courses.Select(b => b.CourseNumber));

            foreach (var course in sampleCourses)
            {
                if (!existingCourseNumbers.Contains(course.CourseNumber))
                {
                    Courses.Add(course);
                }
            }
            SaveChanges();
        }
    }
}
