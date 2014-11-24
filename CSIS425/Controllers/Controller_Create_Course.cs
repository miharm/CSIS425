using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using System.Web.Script;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Collections.Specialized;
using System.Collections;
using CSIS425.Infrastructure.UnitOfWork;
using CSIS425.Models;
using CSIS425.Utility;

namespace CSIS425.Controllers
{
    public class Controller_Create_Course : Controller
    {
        private IUnitOfWork _uow;
        private Model_Courses_IRepository _courseRepository;
        private Model_Players_IRepository _playerRepository;
        private Model_Rounds_IRepository _roundRepository;

        public Controller_Create_Course( IUnitOfWork uow,
                                         Model_Courses_IRepository courseRepository,
                                         Model_Players_IRepository playerRepository,
                                         Model_Rounds_IRepository roundRepository)
        {
            _uow = uow;
            _courseRepository = courseRepository;
            _playerRepository = playerRepository;
            _roundRepository = roundRepository;
        }

        public void run(HttpContext context)
        {
            this.save_course(context);
        }

        [WebMethod][ScriptMethod]
        public void save_course(HttpContext context)
        {
            NameValueCollection request = context.Request.Params;

            Guid course_id = new Guid();
            int holes = Convert.ToInt32(request["holes"]);
            string name = request["name"];
            string pars = request["pars"];

            Model_Courses new_course = new Model_Courses();
            new_course.course_id = course_id;
            new_course.holes = holes;
            new_course.name = name;
            new_course.pars = pars;

            _courseRepository.Add(new_course);
            _uow.Commit();

            UtilityClass.respond(context, true, "", new { });
        }
    }
}