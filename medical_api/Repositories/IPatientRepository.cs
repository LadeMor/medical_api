using System.Collections.Generic;
using System.Threading.Tasks;
using medical_api.Models;

namespace medical_api.Repositories
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> Get();
        Task<Patient> Get(int id);
        Task<Patient> Create(Patient patient);
        Task Update(Patient patient);
        Task Delete(int id);
    }
}