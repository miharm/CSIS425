using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSIS425.Models;
using CSIS425.Infrastructure;
using CSIS425.Infrastructure.UnitOfWork;

namespace CSIS425.NHibernate.Repositories
{
    public class RoundRepository : Repository<Model_Rounds, Guid>, Model_Rounds_IRepository 
    {
        public RoundRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }
    }
}