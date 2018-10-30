using System.Linq;

namespace EM.Calc.Core
{
    public class MultOperation : IOperation
    {
        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Name => "mult";

        public double? Execute()
        {
            Result = Operands.Aggregate((lhs, rhs) => lhs * rhs);
            return Result;
        }
    }
}
