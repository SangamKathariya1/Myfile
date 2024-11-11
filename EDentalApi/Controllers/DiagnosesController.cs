using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Implementations;
using EDental.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnosesController : ControllerBase
    {
        private readonly IDiagnosesRepository diagnosesRepository;

        public DiagnosesController(IDiagnosesRepository diagnosesRepository)
        {
            this.diagnosesRepository = diagnosesRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var diagnoses = diagnosesRepository.Get();
            return Ok(diagnoses);
        }

        [HttpPost]
        public IActionResult Post(Diagnosis diagnosis)
        {
            var result = diagnosesRepository.Insert(diagnosis);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var diagnoses = diagnosesRepository.Get(id);
            if (diagnoses is null)
                return NotFound($"Diagnosis with id {id} not found");
            return Ok(diagnoses);
        }

        [HttpPut]
        public IActionResult Put(Diagnosis diagnoses)
        {
            var result = diagnosesRepository.Edit(diagnoses);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = diagnosesRepository.Delete(id);
            return Ok(result);
        }
    }
}
