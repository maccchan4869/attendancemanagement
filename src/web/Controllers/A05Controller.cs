using BusinessLogic.A05;
using Model.A05;
using System.Web.Mvc;
using ViewModel;
using web.Controllers;

namespace Web.Controllers
{
    public class A05Controller : CommonController
    {
        [Authorize]
        public ActionResult A05()
        {
            var logic = new A05BusinessLogic();
            A05ViewModel vm = logic.Ready();
            return View("A05", vm);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Register(A05RegisterModel Model)
        {
            var logic = new A05BusinessLogic();
            var result = logic.Register(Model);

            return Json(new { result });
        }
    }
}