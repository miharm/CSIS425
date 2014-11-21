using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSIS425.Infrastructure;

namespace CSIS425.Models
{
    public class Model_Courses : IAggregateRoot
    {
        public Guid course_id { get; set; }

        public int holes { get; set; }

        public string pars { get; set; }

        public string name { get; set; }
    }
}