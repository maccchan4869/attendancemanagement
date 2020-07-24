using System.Web.Mvc;
using web.Controllers;

namespace Web.Controllers
{
    public class A01Controller : CommonController
    {
        [Authorize]
        public ActionResult A01()
        {
            return View();
        }
    }
}