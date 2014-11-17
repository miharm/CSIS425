using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSIS425.Models;
using CSIS425.Infrastructure;
using CSIS425.Infrastructure.UnitOfWork;

namespace CSIS425.NHibernate.Repositories
{
    public class CourseRepository : Repository<Model_Courses, Guid>, Model_Courses_IRepository 
    {
        public CourseRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }
    }
}