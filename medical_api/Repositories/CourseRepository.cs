using System.Collections.Generic;
using System.Linq;
using medical_api.Database;
using medical_api.Models;

namespace medical_api.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly MedicalContext _context;

        public CourseRepository(MedicalContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Course> Get()
        {
            return _context.courses.ToList();
        }
    }
}