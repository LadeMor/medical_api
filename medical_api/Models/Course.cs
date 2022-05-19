using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace medical_api.Models
{
    public class Course
    {
        [Key]
        public int course_id { get; set; }
        public string course_name { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}