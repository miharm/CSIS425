using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSIS425.Infrastructure;

namespace CSIS425.Models
{
    public class Model_Users : IAggregateRoot
    {
        public Guid user_id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string password { get; set; }
    }
}