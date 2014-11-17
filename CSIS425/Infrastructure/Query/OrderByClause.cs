using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSIS425.Infrastructure.Query
{
    public class OrderByClause
    {
        public string PropertyName { get; set; }
        public bool Desc { get; set; }
    }
}
