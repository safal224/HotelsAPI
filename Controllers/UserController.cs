using BigAccessment1_HotelsAPI.Models;
using BigAccessment1_HotelsAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUser _Irepo;

        public UserController(UserClass uc)
        {
            _Irepo = uc;
        }

        [HttpPost]
        public ActionResult AddUser(User model)
        {
            if (ModelState.IsValid)
            {
                _Irepo.Insert(model);
                _Irepo.Save();


            }
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var user = _Irepo.GetUsers();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {

            var user = _Irepo.GetUsers();
            return Ok(user);
        }
        [Authorize]
        [HttpDelete]

        public IActionResult DeleteById(int id)
        {
            var user = _Irepo.Delete(id);
            return Ok(user);
        }
    }
}
