using System.Collections.Generic;
using System.Threading.Tasks;
using medical_api.Database;
using medical_api.Models;
using Microsoft.EntityFrameworkCore;

namespace medical_api.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly MedicalContext _context;

        public PatientRepository(MedicalContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Patient>> Get()
        {
            return await _context.patients.ToListAsync();
        }

        public async Task<Patient> Get(int id)
        {
            return await _context.patients.FindAsync(id);
        }

        public async Task<Patient> Create(Patient patient)
        {
            _context.patients.Add(patient);
            await _context.SaveChangesAsync();

            return patient;
        }

        public async Task Update(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var patientToDelete = await _context.patients.FindAsync(id);
            _context.patients.Remove(patientToDelete);
            await _context.SaveChangesAsync();
        }
    }
}