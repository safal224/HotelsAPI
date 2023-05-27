using BigAccessment1_HotelsAPI.Models;
using BigAccessment1_HotelsAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly InterfaceInformation _Irepo;

        public InformationController(InformationClass ic)
        {
            _Irepo = ic;
        }

        [HttpPost]
        public ActionResult AddInformation(Information model)
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
            var info = _Irepo.GetInformation();
            return Ok(info);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {

            var info = _Irepo.GetInformation();
            return Ok(info);
        }
        [Authorize]
        [HttpDelete]

        public IActionResult DeleteById(int id)
        {
            var info = _Irepo.Delete(id);
            return Ok(info);
        }
    }
}
