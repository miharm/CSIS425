using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Specialized;
using CSIS425.Models;
using CSIS425.Infrastructure.UnitOfWork;
using System.Web.Services;
using System.Web.Script;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using CSIS425.Utility;

namespace CSIS425.Controllers
{
    public class Controller_Create_User : Base_Controller
    {
        private IUnitOfWork _uow;
        private Model_Courses_IRepository _courseRepository;
        private Model_Players_IRepository _playerRepository;
        private Model_Rounds_IRepository _roundRepository;
        private Model_Users_IRepository _userRespository;

        public Controller_Create_User(IUnitOfWork uow,
                                      Model_Courses_IRepository courseRepository,
                                      Model_Players_IRepository playerRepository,
                                      Model_Rounds_IRepository roundRepository,
                                      Model_Users_IRepository userRespository)
        {
            _uow = uow;
            _courseRepository = courseRepository;
            _playerRepository = playerRepository;
            _roundRepository = roundRepository;
            _userRespository = userRespository;
        }

        public void run(HttpContext context)
        {
            this.save_user(context);
        }

        [WebMethod][ScriptMethod]
        public void save_user(HttpContext context)
        {
            NameValueCollection request = context.Request.Params;

            Guid user_id = new Guid();
            string first_name = request["first_name"];
            string last_name = request["last_name"];
            string user_name = request["user_name"];
            string password = request["password"];

            Model_Users new_user = new Model_Users();
            new_user.user_id = user_id;
            new_user.first_name = first_name;
            new_user.last_name = last_name;
            new_user.user_name = user_name;
            new_user.password = password;

            _userRespository.Add(new_user);
            _uow.Commit();

            UtilityClass.respond(context, true, "", new { });
        }
    }
}