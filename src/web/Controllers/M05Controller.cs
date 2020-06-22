using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Controllers;

namespace Web.Controllers
{
    public class M05Controller : CommonController
    {
        [HttpPost]
        [Authorize]
        public ActionResult Apply()
        {
            return Json(new { result = "" });
        }
    }
}