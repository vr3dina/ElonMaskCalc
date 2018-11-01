using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class SumOperation : IExtOperation
    {
        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Name => "sum";

        public Guid Uid => new Guid("{6EFA1DF8-5C93-4D58-9A86-661C5B256D50}");

        public string Description => "Суммирует все элементы";

        public int? ArgCount => 2;

        public double? Execute()
        {
            Result = Operands.Sum();
            return Result;
        }
    }
}
