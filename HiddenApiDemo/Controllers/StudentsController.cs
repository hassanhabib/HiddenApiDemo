using Microsoft.AspNetCore.Mvc;

namespace HiddenApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Here's my students");

        [HttpDelete]
        public ActionResult<string> Delete() =>
            Ok("Deleted All Students!!!");
    }
}
