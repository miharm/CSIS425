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

namespace CSIS425.Controllers
{
    public class Controller_Join_Round : Base_Controller
    {
        private IUnitOfWork _uow;
        private Model_Courses_IRepository _courseRepository;
        private Model_Players_IRepository _playerRepository;
        private Model_Rounds_IRepository _roundRepository;
        private Model_Users_IRepository _userRespository;

        public Controller_Join_Round(IUnitOfWork uow,
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

        public void run(HttpContext parameters)
        {

        }
    }
}