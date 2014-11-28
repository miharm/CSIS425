using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using CSIS425.Infrastructure;
using CSIS425.Infrastructure.Query;

namespace CSIS425.Models
{
    public interface Model_Users_IRepository
    {
        void Add(Model_Users player);
        void Remove(Model_Users player);
        void Save(Model_Users player);

        Model_Users FindBy(Guid Id);

        IEnumerable<Model_Users> FindAll();
        IEnumerable<Model_Users> FindAll(int index, int count);

        IEnumerable<Model_Users> FindBy(Query query);
        IEnumerable<Model_Users> FindBy(Query query, int index, int count);
    }
}