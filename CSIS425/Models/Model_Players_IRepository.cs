using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using CSIS425.Infrastructure;
using CSIS425.Infrastructure.Query;

namespace CSIS425.Models
{
    public interface Model_Players_IRepository
    {
        void Add(Model_Players player);
        void Remove(Model_Players player);
        void Save(Model_Players player);

        Model_Players FindBy(Guid Id);

        Model_Players FindBy(Guid player_id, Guid round_id);

        IEnumerable<Model_Players> FindAll();
        IEnumerable<Model_Players> FindAll(int index, int count);

        IEnumerable<Model_Players> FindBy(Query query);
        IEnumerable<Model_Players> FindBy(Query query, int index, int count);      
    }
}