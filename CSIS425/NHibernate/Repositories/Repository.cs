﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using CSIS425.Infrastructure.UnitOfWork;
using CSIS425.Infrastructure;
using CSIS425.Infrastructure.Query;

namespace CSIS425.NHibernate.Repositories
{    
    public abstract class Repository<T, EntityKey> where T : IAggregateRoot
    {
        private IUnitOfWork _uow;

        public Repository(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Add(T entity)
        {
            _uow.RegisterNew(entity, null);

            SessionFactory.GetCurrentSession().Save(entity);
        }

        public void Remove(T entity)
        {
            SessionFactory.GetCurrentSession().Delete(entity);
        }

        public void Save(T entity)
        {
            SessionFactory.GetCurrentSession().SaveOrUpdate(entity);
        }

        public T FindBy(EntityKey Id)
        {
            return SessionFactory.GetCurrentSession().Get<T>(Id);
        }   

        public IEnumerable<T> FindAll()
        {
            ICriteria CriteriaQuery = SessionFactory.GetCurrentSession().CreateCriteria(typeof(T));

            return (List<T>)CriteriaQuery.List<T>();
        }

        public IEnumerable<T> FindAll(int index, int count)
        {
            ICriteria CriteriaQuery = SessionFactory.GetCurrentSession().CreateCriteria(typeof(T));

            return (List<T>)CriteriaQuery.SetFetchSize(count).SetFirstResult(index).List<T>();
        }

        public IEnumerable<T> FindBy(Query query)
        {
            ICriteria nhQuery = query.TranslateIntoNHQuery<T>();

            return nhQuery.List<T>();
        }

        public IEnumerable<T> FindBy(Query query, int index, int count)
        {
            ICriteria nhQuery = query.TranslateIntoNHQuery<T>();

            return nhQuery.SetFetchSize(count).SetFirstResult(index).List<T>();
        } 
    }
}
