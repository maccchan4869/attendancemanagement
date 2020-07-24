using System.Web.Mvc;
using web.Controllers;

namespace Web.Controllers
{
    public class A06Controller : CommonController
    {
        [Authorize]
        public ActionResult A06()
        {
            return View();
        }
    }
}