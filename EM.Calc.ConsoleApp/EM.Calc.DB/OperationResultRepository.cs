using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.DB
{
    public class OperationResultRepository : BaseRepository<OperationResult>
    {
        public OperationResultRepository(string connection) : base(connection)
        {
        }

        //public override string Fields { get =>  }
    }
}
