using BusinessLogic.M05;
using Model.M05;
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
        public ActionResult Apply(ApplyVacationModel Model)
        {
            Model.UserId = GetUserId();
            var logic = new M05BusinessLogic();
            var result = logic.RegisterVacation(Model);

            return Json(new { result });
        }
    }
}