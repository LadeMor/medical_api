using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> GetPatients()
        {
            var patients = _patientRepository.Get();
            var patientsModels = patients.Select(p=> new PatientsFull(){
                id = p.id, 
                name = p.name, 
                surname = p.surname, 
                arrivaldate = p.arrivaldate,
                diagnosis = p.Diagnose.diagnosis_name, 
                courses = p.Course.course_name
                    
            });
            return Ok(patientsModels);
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

        [HttpDelete("{id}")]
        public void DeletePatient(int id)
        {
            _patientRepository.Delete(id);
        }
    }
}