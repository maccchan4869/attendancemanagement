using BusinessLogic.M06;
using Model.M06;
using System.Web.Mvc;
using web.Controllers;

namespace Web.Controllers
{
    public class M06Controller : CommonController
    {
        [HttpPost]
        [Authorize]
        public ActionResult Cancel(CancelVacationModel Model)
        {
            Model.UserId = GetUserId();
            var logic = new M06BusinessLogic();
            var result = logic.DeleteVacation(Model);

            return Json(new { result });
        }
    }
}