using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSIS425.Models;
using CSIS425.Infrastructure;
using CSIS425.Infrastructure.UnitOfWork;

namespace CSIS425.NHibernate.Repositories
{
    public class UserRepository : Repository<Model_Users, Guid>, Model_Users_IRepository 
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }
    }
}