using System.Linq;

namespace EM.Calc.Core
{
    public class NewOperation : IOperation
    {
        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Name => "new";

        public double? Execute()
        {
            Result = double.PositiveInfinity; 
            return Result;
        }
    }
}
