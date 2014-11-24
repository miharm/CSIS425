using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace CSIS425.Utility
{
    public static class UtilityClass
    {
        public static void respond(HttpContext context, bool success, string message, object data)
        {
            context.Response.Write(
                new JavaScriptSerializer().Serialize(
                    new
                    {
                        success = success,
                        message = message,
                        data = data
                    }
                )
            );
        }
    }
}