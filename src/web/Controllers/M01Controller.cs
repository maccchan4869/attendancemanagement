using System.Web.Mvc;
using web.Controllers;

namespace Web.Controllers
{
    public class M01Controller : CommonController
    {
        [Authorize]
        public ActionResult M01()
        {
            return View();
        }
    }
}