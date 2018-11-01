using System;
using System.Linq;

namespace EM.Calc.Core
{
    class SubOperation : IExtOperation
    {
        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Name => "sub";

        public Guid Uid => new Guid("{E1FABCBC-7662-40F3-A835-ADC4046DF388}");

        public string Description => "Вычитает все элементы";

        public int? ArgCount => 2;

        public double? Execute()
        {
            Result = Operands.Aggregate((lhs, rhs) => lhs - rhs);
            return Result;
        }
    }
}