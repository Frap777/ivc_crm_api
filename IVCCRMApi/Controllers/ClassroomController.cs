using IVCCRMApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IVCCRMApi.Controllers
{
    [ApiController]
    [Route("classroom")]
    public class ClassroomContoller : ControllerBase
    {

        [HttpGet]
        [Route("all")]
        public IActionResult All()
        {
            IVCContext db = new IVCContext();
            return Ok(db.Classrooms);
        }
        [HttpPost]
        public ActionResult Add(Classroom classroom)
        {
            IVCContext db = new IVCContext();
            db.Classrooms.Add(classroom);
            db.SaveChanges();
            return Ok(classroom);
        }
    }
}
