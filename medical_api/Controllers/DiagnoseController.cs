using System.Collections;
using System.Collections.Generic;
using medical_api.Models;
using medical_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace medical_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnoseController : ControllerBase
    {
        private readonly IDiagnoseRepository _diagnoseRepository;

        public DiagnoseController(IDiagnoseRepository diagnoseRepository)
        {
            _diagnoseRepository = diagnoseRepository;
        }

        [HttpGet]
        public IEnumerable<Diagnose> GetDiagnoses()
        {
            return _diagnoseRepository.Get();
        }
    }
}