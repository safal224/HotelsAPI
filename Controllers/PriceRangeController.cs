using BigAccessment1_HotelsAPI.Models;
using BigAccessment1_HotelsAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceRangeController : ControllerBase
    {
        private readonly IPriceRange _Irepo;

        public PriceRangeController(PriceRangeClass Prc)
        {
            _Irepo = Prc;
        }

        [HttpPost]
        public ActionResult AddRange(PriceRange model)
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
            var Prange = _Irepo.GetDetails();
            return Ok(Prange);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {

            var Prange = _Irepo.GetDetails();
            return Ok(Prange);
        }
        [Authorize]
        [HttpDelete]

        public IActionResult DeleteById(int id)
        {
            var Prange = _Irepo.Delete(id);
            return Ok(Prange);
        }
    }
}
