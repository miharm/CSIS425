using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Specialized;
using CSIS425.Models;
using CSIS425.Infrastructure.UnitOfWork;

namespace CSIS425.Controllers
{
    public class Controller_Create_User : Controller
    {
        private IUnitOfWork _uow;
        private Model_Courses_IRepository _courseRepository;
        private Model_Players_IRepository _playerRepository;
        private Model_Rounds_IRepository _roundRepository;

        public Controller_Create_User(IUnitOfWork uow,
                                      Model_Courses_IRepository courseRepository,
                                      Model_Players_IRepository playerRepository,
                                      Model_Rounds_IRepository roundRepository)
        {
            _uow = uow;
            _courseRepository = courseRepository;
            _playerRepository = playerRepository;
            _roundRepository = roundRepository;
        }

        public void run(NameValueCollection parameters)
        {

        }
    }
}