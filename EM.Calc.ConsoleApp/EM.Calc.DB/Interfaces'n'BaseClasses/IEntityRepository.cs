using System.Collections.Generic;

namespace EM.Calc.DB
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        T Create();

        T Load(long id);

        void Update(T entity);

        void Delete(long id);

        IEnumerable<T> GetAll();
    }
}
