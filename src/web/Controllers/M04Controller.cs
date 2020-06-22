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
            var userId = GetUserId();
            var logic = new M04BusinessLogic();
            M04ViewModel vm = logic.Ready(userId);
            return View("M04", vm);
        }
    }
}