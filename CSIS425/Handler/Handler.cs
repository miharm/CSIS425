using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using System.Web.Mvc;
using CSIS425.Controllers;
using CSIS425.Infrastructure.UnitOfWork;
using CSIS425.NHibernate;
using CSIS425.NHibernate.Repositories;
using CSIS425.Models;

namespace CSIS425.Handler
{
    public class Handler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;

            Base_Controller controller;
            IUnitOfWork uow = new NHUnitOfWork();
            Model_Courses_IRepository courseRepository = new CourseRepository( uow );
            Model_Players_IRepository playerRepository = new PlayerRepository(uow);
            Model_Rounds_IRepository roundRepository = new RoundRepository(uow);

            switch ( parameters["action"] )
            {
                case "manage_create_course":
                    controller = new Controller_Create_Course(uow, courseRepository, playerRepository, roundRepository);
                    break;
                case "manage_create_user":
                    controller = new Controller_Create_User(uow, courseRepository, playerRepository, roundRepository);
                    break;
                case "manage_join_round":
                    controller = new Controller_Join_Round(uow, courseRepository, playerRepository, roundRepository);
                    break;
                case "manage_score_card":
                    controller = new Controller_Score_Card(uow, courseRepository, playerRepository, roundRepository);
                    break;
                default:
                    controller = new Controller_Invalid_Action();
                    break;
            }

            controller.run(parameters);

        }
    }
}