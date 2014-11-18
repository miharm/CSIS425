using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using System.Web.Mvc;
using CSIS425.Controllers;

namespace CSIS425.Handler
{
    public class Handler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;

            Base_Controller controller;

            switch ( parameters["action"] )
            {
                case "manage_create_course":
                    controller = new Controller_Create_Course();
                    break;
                case "manage_create_user":
                    controller = new Controller_Create_User();
                    break;
                case "manage_join_round":
                    controller = new Controller_Join_Round();
                    break;
                case "manage_score_card":
                    controller = new Controller_Score_Card();
                    break;
                default:
                    controller = new Controller_Invalid_Action();
                    break;
            }

            controller.run(parameters);

        }
    }
}