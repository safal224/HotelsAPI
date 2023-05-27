using BigAccessment1_HotelsAPI.Models;
using BigAccessment1_HotelsAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly ILocationRepo _ILocationrepo;

        public LocationController(LocationClass lc)
        {
            _ILocationrepo = lc;
        }

        [HttpPost]
        public ActionResult AddLocation(Location model)
        {
            if (ModelState.IsValid)
            {
                _ILocationrepo.Insert(model);
                _ILocationrepo.Save();


            }
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var location = _ILocationrepo.GetLocation();
            return Ok(location);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {

            var location = _ILocationrepo.GetLocation();
            return Ok(location);
        }
        [Authorize]
        [HttpDelete]

        public IActionResult DeleteById(int id)
        {
            var location = _ILocationrepo.Delete(id);
            return Ok(location);
        }
    }
}
