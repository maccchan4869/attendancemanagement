using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class CommonController : Controller
    {
        protected string GetUserId()
        {
            string[] userId = User.Identity.Name.Split('@');
            return userId[0];
        }
    }
}