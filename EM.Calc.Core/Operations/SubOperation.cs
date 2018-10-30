using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    class SubOperation : IOperation
    {
        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Name => "sub";

        public double? Execute()
        {
            Result = Operands.Aggregate((lhs, rhs) => lhs - rhs);
            return Result;
        }
    }
}
