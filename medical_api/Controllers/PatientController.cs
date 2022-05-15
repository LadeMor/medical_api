using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using medical_api.Models;
using medical_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace medical_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;

        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Patient>> GetPatients()
        {
            return await _patientRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatients(int id)
        {
            return await _patientRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Patient>> CreatePatient(Patient patient)
        {
            return await _patientRepository.Create(patient);
        }

        [HttpDelete]
        public void DeletePatient(int id)
        {
            _patientRepository.Delete(id);
        }
    }
}