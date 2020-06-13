using System.Web.Mvc;


namespace Web.Controllers
{
    public class M01Controller : Controller
    {
        [Authorize]
        public ActionResult M01()
        {
            return View();
        }
    }
}