using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSIS425.Infrastructure;

namespace CSIS425.Models
{
    public class Model_Rounds : IAggregateRoot
    {
        public Guid round_id { get; set; }

        public Guid course_id { get; set; }
    }
}