using System.Collections.Generic;
using System.Linq;
using medical_api.Database;
using medical_api.Models;

namespace medical_api.Repositories
{
    public class DiagnoseRepository : IDiagnoseRepository
    {
        private readonly MedicalContext _context;

        public DiagnoseRepository(MedicalContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Diagnose> Get()
        {
            return _context.diagnoses.ToList();
        }
    }
}