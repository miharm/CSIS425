using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Specialized;
using CSIS425.Infrastructure.UnitOfWork;
using CSIS425.Models;

namespace CSIS425.Controllers
{

    public class Controller_Score_Card : Base_Controller 
    {
        private IUnitOfWork _uow;
        private Model_Courses_IRepository _courseRepository;
        private Model_Players_IRepository _playerRepository;
        private Model_Rounds_IRepository _roundRepository;

        public Controller_Score_Card(IUnitOfWork uow,
                                     Model_Courses_IRepository courseRepository,
                                     Model_Players_IRepository playerRepository,
                                     Model_Rounds_IRepository roundRepository)
        {
            _uow = uow;
            _courseRepository = courseRepository;
            _playerRepository = playerRepository;
            _roundRepository = roundRepository;
        }

        public new void run(NameValueCollection request)
        {
            switch (request["command"])
            {
                case "load_page":
                    //load the page
                    this.load_page(request);
                    break;
                case "save_score":
                    //save the new score
                    this.save_score(request);
                    break;
            }
        }

        private Hashtable load_page(NameValueCollection request)
        {
            Hashtable response = new Hashtable();

            Guid course_id = new Guid( request["course_id"] );
            Guid player_id = new Guid( request["player_id"] );

            //load the course record
            Model_Courses course = _courseRepository.FindBy(course_id);

            //load the player record
            Model_Players player = _playerRepository.FindBy(player_id);

            response["success"] = true;
            response["message"] = "";
            return response;
        }

        private Hashtable save_score(NameValueCollection request)
        {
            Hashtable response = new Hashtable();

            //load the player record
            Guid player_id = new Guid(request["player_id"]);
            Model_Players player = _playerRepository.FindBy(player_id);

            //put the new score in
            player.score = request["score"];

            _playerRepository.Add(player);
            _uow.Commit();

            response["success"] = true;
            response["message"] = "";
            return response;
        }
    }
}