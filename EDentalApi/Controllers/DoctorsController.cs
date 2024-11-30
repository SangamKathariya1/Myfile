using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorsRepository doctorsRepository;

        public DoctorsController(IDoctorsRepository doctorsRepository)
        {
            this.doctorsRepository = doctorsRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var doctors = doctorsRepository.Get();
            return Ok(doctors);
        }

        [HttpPost]
        public IActionResult Post(Doctor doctor)
        {
            var result = doctorsRepository.Insert(doctor);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var doctor = doctorsRepository.Get(id);
            if (doctor is null)
                return NotFound($"Doctor with id {id} not found");
            return Ok(doctor);
        }

        [HttpPut]
        public IActionResult Put(Doctor doctor)
        {
            var result = doctorsRepository.Edit(doctor);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int doctor)
        {
            int result = doctorsRepository.Delete(doctor);
            return Ok(result);
        }
    }
}
