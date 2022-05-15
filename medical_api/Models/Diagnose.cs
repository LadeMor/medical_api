using System.ComponentModel.DataAnnotations;

namespace medical_api.Models
{
    public class Diagnose
    {
        [Key]
        public int diagnosis_id { get; set; }
        public string diagnosis_name { get; set; }
    }
}