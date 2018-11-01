using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class MultOperation : IExtOperation
    {
        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Name => "mult";

        public double? Execute()
        {
            Result = Operands.Aggregate((lhs, rhs) => lhs * rhs);
            return Result;
        }

        public Guid Uid => Guid.NewGuid();

        public string Description => "Перемножает все элементы";

        public int? ArgCount => 0;

    }
}
