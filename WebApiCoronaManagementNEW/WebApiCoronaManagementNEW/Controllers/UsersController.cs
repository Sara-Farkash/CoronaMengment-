using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;
using Microsoft.AspNetCore.Components.Forms;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCoronaManagementNEW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserBll userBll;
        public UsersController(IUserBll userBll)
        {
            this.userBll = userBll;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public List<User1Dto> Get()
        {
            return this.userBll.getAllUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User1Dto Get(int id)
        {
            return this.userBll.GetUserByID(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User1Dto user)
        {        
                this.userBll.AddUser(user);           
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }



        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("getMas")]
        public int  GetMas()
        {
           return this.userBll.notVaccination();
        }
    }
}
