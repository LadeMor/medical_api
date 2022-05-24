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
        public async Task<IActionResult> CreatePatient(NewPatientModel newPatientModel)
        {
            var patient = new Patient()
            {
                name = newPatientModel.name,
                surname = newPatientModel.surname,
                arrivaldate = newPatientModel.arrivaldate,
                diagnosis = newPatientModel.diagnosis,
                courses = newPatientModel.courses
            };
            await _patientRepository.Create(patient);
            return Ok();
        }

        [HttpDelete("{id}")]
        public void DeletePatient(int id)
        {
            _patientRepository.Delete(id);
        }
    }
}