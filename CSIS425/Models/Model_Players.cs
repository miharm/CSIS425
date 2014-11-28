using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSIS425.Infrastructure;

namespace CSIS425.Models
{
    public class Model_Players : IAggregateRoot
    {
        public Guid player_id { get; set; }

        public Guid round_id { get; set; }

        public Guid user_id { get; set; }

        public string score { get; set; }
    }
}