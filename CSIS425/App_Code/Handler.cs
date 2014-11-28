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
using CSIS425.Utility;
using System.Web.Script;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

public class Handler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        NameValueCollection parameters = context.Request.Params;

        IUnitOfWork uow = new NHUnitOfWork();
        Model_Courses_IRepository courseRepository = new CourseRepository(uow);
        Model_Players_IRepository playerRepository = new PlayerRepository(uow);
        Model_Rounds_IRepository roundRepository = new RoundRepository(uow);
        Model_Users_IRepository userRepository = new UserRepository(uow);

        try
        {
            switch (parameters["action"])
            {
                case "manage_create_course":
                    Controller_Create_Course controller_create_course = new Controller_Create_Course(uow, courseRepository, playerRepository, roundRepository, userRepository);
                      controller_create_course.run(context);
                    break;
                case "manage_create_user":
                    Controller_Create_User controller_create_user = new Controller_Create_User(uow, courseRepository, playerRepository, roundRepository, userRepository);
                    controller_create_user.run(context);
                    break;
                case "manage_join_round":
                    Controller_Join_Round controller_join_round = new Controller_Join_Round(uow, courseRepository, playerRepository, roundRepository, userRepository);
                    controller_join_round.run(context);
                    break;
                case "manage_score_card":
                    Controller_Score_Card controller_score_card = new Controller_Score_Card(uow, courseRepository, playerRepository, roundRepository, userRepository);
                    controller_score_card.run(context);
                    break;
                default:
                    Controller_Invalid_Action controller_invalid_action = new Controller_Invalid_Action();
                    controller_invalid_action.run(context);
                    break;
            }

        }
        catch (Exception ex)
        {
            UtilityClass.respond(context, false, ex.ToString(), new { });
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}
