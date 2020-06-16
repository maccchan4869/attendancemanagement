using BusinessLogic.M04;
using System.Web.Mvc;
using ViewModel;
using web.Controllers;

namespace Web.Controllers
{
    public class M04Controller : CommonController
    {
        [Authorize]
        public ActionResult M04()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Ready()
        {
            var userId = GetUserId();
            var logic = new M04BusinessLogic();
            M04ViewModel ret = logic.Ready(userId);

            return Json(new { result = ret });
        }
    }
}