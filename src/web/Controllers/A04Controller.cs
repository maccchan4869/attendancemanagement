using System.Web.Mvc;
using web.Controllers;

namespace Web.Controllers
{
    public class A04Controller : CommonController
    {
        [Authorize]
        public ActionResult A04()
        {
            return View();
        }
    }
}