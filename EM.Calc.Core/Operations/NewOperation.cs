using System;

namespace EM.Calc.Core
{
    public class NewOperation : IExtOperation
    {
        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Name => "new";

        public Guid Uid => new Guid("{8591E321-3B47-417C-84C7-8835694832A2}");

        public string Description => "Возвращает бесконечность";

        public int? ArgCount => 0;

        public double? Execute()
        {
            Result = double.PositiveInfinity;
            return Result;
        }
    }
}
