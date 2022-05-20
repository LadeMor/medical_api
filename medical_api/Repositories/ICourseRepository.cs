using System.Collections;
using System.Collections.Generic;
using medical_api.Models;

namespace medical_api.Repositories
{
    public interface ICourseRepository
    {
        IEnumerable<Course> Get();
    }
}