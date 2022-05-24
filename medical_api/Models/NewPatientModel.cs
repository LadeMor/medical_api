using System;

namespace medical_api.Models
{
    public class NewPatientModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime arrivaldate { get; set; }
        public int diagnosis { get; set; }
        public int courses { get; set; }
    }
}