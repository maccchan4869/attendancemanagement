using BusinessLogic.M04;
using System.Web.Mvc;
using ViewModel;

namespace Web.Controllers
{
    public class M04Controller : Controller
    {
        public ActionResult M04()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ready()
        {
            var logic = new M04BusinessLogic();
            M04ViewModel ret = logic.Ready();

            return Json(new { result = ret });
        }
    }
}