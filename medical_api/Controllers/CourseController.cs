using System.Collections;
using System.Collections.Generic;
using medical_api.Models;
using medical_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace medical_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        public IEnumerable<Course> GetCourses()
        {
            return _courseRepository.Get();
        }
    }
}