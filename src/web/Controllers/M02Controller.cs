using System.Web.Mvc;

namespace Web.Controllers
{
    public class M02Controller : Controller
    {
        [Authorize]
        public ActionResult M02() 
        {
            return View();
        }
    }
}