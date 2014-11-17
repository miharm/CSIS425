using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSIS425.Models;
using CSIS425.Infrastructure;
using CSIS425.Infrastructure.UnitOfWork;

namespace CSIS425.NHibernate.Repositories
{
    public class PlayerRepository : Repository<Model_Players, Guid>, Model_Players_IRepository 
    {
        public PlayerRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }
    }
}