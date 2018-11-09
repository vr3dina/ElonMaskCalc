using NHibernate;
using NHibernate.Criterion;

namespace EM.Calc.DB.NHibernate
{
    public class NHOperationRepository : NHBaseRepository<Operation>, IOperationRepository
    {
        public Operation LoadByName(string name)
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            var operation = session.CreateCriteria<Operation>()
                .Add(Restrictions.Eq("Name", name))
                .UniqueResult<Operation>();

            NHibernateHelper.CloseSession();

            return operation;
        }
    }
}
