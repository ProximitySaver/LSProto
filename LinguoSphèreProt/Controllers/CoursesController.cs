using LinguoSphèreProt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LinguoSphèreProt.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IQueryable<Course> coursesQuery = _context.Courses
                                                      .Include(c =>c.Langue)
                                                      .Include(d => d.Niveau);

            var courses = await coursesQuery.ToListAsync();
            
            return View(courses);
        }

        public async Task<IActionResult> Detail(int id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }
            var course = await _context.Courses
                .Include(c => c.Langue)
                .Include(d => d.Niveau)
                .Include(e => e.Features)
                .FirstOrDefaultAsync(m => m.CourseID == id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }
    }
}
