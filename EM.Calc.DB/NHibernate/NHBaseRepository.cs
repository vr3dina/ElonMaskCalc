using NHibernate;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace EM.Calc.DB.NHibernate
{
    public class NHBaseRepository<T> : IEntityRepository<T> where T : class, IEntity
    {
        public T Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var obj = session.Get<T>(id);
                    session.Delete(obj);
                    transaction.Commit();
                }
            }
        }

        public IEnumerable<T> GetAll()
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var list = session.CreateCriteria<T>()
                .List<T>();

            NHibernateHelper.CloseSession();

            return list;
        }

        public T Load(long id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var entity = session.Load<T>(id);

            NHibernateHelper.CloseSession();

            return entity;
        }

        public void Save(T entity)
        {
            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(entity); 
                    transaction.Commit();
                }
            };
        }
    }
}
