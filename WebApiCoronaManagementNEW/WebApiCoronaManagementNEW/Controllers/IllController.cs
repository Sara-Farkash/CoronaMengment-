using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCoronaManagementNEW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IllController : ControllerBase
    {
        private IIllBll illBll;
        public IllController(IIllBll illBll)
        {
            this.illBll = illBll;
        }
        // GET: api/<IllController>
        [HttpGet]
        public List<IllDto> Get()
        {
            return this.illBll.GetAllIlls();
        }


        // GET api/<IllController>/5
        [HttpGet("{id}")]
        public IllDto Get(int id)
        {
            return this.illBll.GetIllById(id);
        }


        // POST api/<IllController>
        [HttpPost]
        public void Post([FromBody] IllDto illDto)
        {
            illBll.AddIll(illDto);
        }


        // PUT api/<IllController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IllController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
