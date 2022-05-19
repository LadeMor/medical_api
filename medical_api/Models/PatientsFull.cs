using System;

namespace medical_api.Models
{
    public class PatientsFull
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime arrivaldate { get; set; }
        public string diagnosis { get; set; }
        public string courses { get; set; }
    }
}