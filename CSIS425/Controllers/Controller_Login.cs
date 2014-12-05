using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Specialized;
using CSIS425.Infrastructure.UnitOfWork;
using CSIS425.Models;
using System.Web.Services;
using System.Web.Script;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using CSIS425.Utility;
using System.Collections.Generic;
using System.Web.SessionState;

namespace CSIS425.Controllers
{
    public class Controller_Login : Base_Controller
    {

                private IUnitOfWork _uow;
        private Model_Courses_IRepository _courseRepository;
        private Model_Players_IRepository _playerRepository;
        private Model_Rounds_IRepository _roundRepository;
        private Model_Users_IRepository _userRespository;

        public Controller_Login(IUnitOfWork uow,
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
            this.login(context);
        }

        [WebMethod]
        [ScriptMethod]
        private void login(HttpContext context)
        {
            NameValueCollection request = context.Request.Params;
            bool found = false;
           IEnumerable<Model_Users> users = _userRespository.FindAll();
            foreach (Model_Users user in users)
            {
                if (request["user_name"] == user.user_name && request["password"] == user.password)
                {
                    found = true;
                    //HttpContext.Current.Session["user_id"] = user.user_id;
                    break;
                }

            }//end foreach
           
            UtilityClass.respond(context, found, "", new { });
            
        }//end login

    }//end class
}//end namespace