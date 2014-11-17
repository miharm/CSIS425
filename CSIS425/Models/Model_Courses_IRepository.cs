using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using CSIS425.Infrastructure;
using CSIS425.Infrastructure.Query;

namespace CSIS425.Models
{
    public interface Model_Courses_IRepository
    {
        void Add(Model_Courses course);
        void Remove(Model_Courses course);
        void Save(Model_Courses course);

        Model_Courses FindBy(Guid Id);

        IEnumerable<Model_Courses> FindAll();
        IEnumerable<Model_Courses> FindAll(int index, int count);

        IEnumerable<Model_Courses> FindBy(Query query);
        IEnumerable<Model_Courses> FindBy(Query query, int index, int count);     
    }
}