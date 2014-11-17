using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace CSIS425.NHibernate.SessionStorage
{
    public interface ISessionStorageContainer
    {
        ISession GetCurrentSession();
        void Store(ISession session);
    }
}
