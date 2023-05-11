using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCoronaManagementNEW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationController : ControllerBase
    {
        private IVaccinationBll vaccinationBll;
        public VaccinationController(IVaccinationBll vaccinationBll)
        {
            this.vaccinationBll = vaccinationBll;
        }
        // GET: api/<VaccinationController>
        [HttpGet]
        public List<VaccinationDto> Get()
        {
            return this.vaccinationBll.GetAllVaccination();
        }

        // POST api/<VaccinationController>
        [HttpPost]
        public void Post([FromBody] VaccinationDto vaccination)
        {
            this.vaccinationBll.AddVaccination(vaccination);
        }

        // PUT api/<VaccinationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VaccinationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
