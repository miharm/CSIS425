using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Specialized;
using CSIS425.Utility;
using System.Web.Services;
using System.Web.Script;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace CSIS425.Controllers
{
    public class Controller_Invalid_Action : Controller
    {
        public void run(HttpContext context)
        {
            //they provided an action that we don't know how to handle
            this.respond(context);
        }

        [WebMethod][ScriptMethod]
        public void respond(HttpContext context)
        {
            UtilityClass.respond(context, true, "An invalid action was provided", new { });
        }
    }
}