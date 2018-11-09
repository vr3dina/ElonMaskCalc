using System.Linq;

namespace EM.Calc.DB
{
    public class OperationRepository : BaseRepository<Operation>, IOperationRepository
    {
        public OperationRepository(string connection) : base(connection)
        {
        }

        public Operation LoadByName(string name)
        {
            var fields = string.Join(",", properties.Select(p => p.Name));
            var loaded = Load($"SELECT {fields} FROM {TableName} WHERE Name = N'{name}';");
            return (loaded.Count<Operation>() == 1) ? loaded.ElementAt(0) : null;
        }
    }
}
