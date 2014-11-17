using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using CSIS425.Infrastructure;
using CSIS425.Infrastructure.Query;

namespace CSIS425.Models
{
    public interface Model_Rounds_IRepository
    {
        void Add(Model_Rounds round);
        void Remove(Model_Rounds round);
        void Save(Model_Rounds round);

        Model_Rounds FindBy(Guid Id);

        IEnumerable<Model_Rounds> FindAll();
        IEnumerable<Model_Rounds> FindAll(int index, int count);

        IEnumerable<Model_Rounds> FindBy(Query query);
        IEnumerable<Model_Rounds> FindBy(Query query, int index, int count);
    }
}