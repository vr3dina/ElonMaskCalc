using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class PowOperation : IOperation
    {
        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Name => "pow";

        public double? Execute()
        {
            Result = Operands.Aggregate((n, p) => Math.Pow(n, p));
            return Result;
        }
    }
}