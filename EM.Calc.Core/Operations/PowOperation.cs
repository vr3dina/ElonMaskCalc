using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class PowOperation : IExtOperation
    {
        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Name => "pow";

        public Guid Uid => new Guid("{079C2161-582C-4F24-9F4B-EB974CD65507}");

        public string Description => "Возведение в степень";

        public int? ArgCount => 2; 

        public double? Execute()
        {
            Result = Operands.Aggregate((n, p) => Math.Pow(n, p));
            return Result;
        }
    }
}