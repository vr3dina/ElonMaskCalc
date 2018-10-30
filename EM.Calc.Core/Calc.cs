using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class Calc
    {
        public IOperation[] Operations { get; set; }
   
        public Calc()
        {
            Operations = new IOperation[]
                {
                    new SumOperation(),
                    new NewOperation()
                };
        }

        public double? Calculate(string op, double[] args)
        {
            foreach (var operation in Operations)
            {
                if (operation.Name == op)
                {
                    operation.Operands = args;
                    return operation.Execute();
                }
            }

            throw new Exception("Operation not found");
        }

        public double? Mult(double[] args)
        {
            return args.Aggregate((lhs, rhs) => lhs * rhs);
        }

        public double? Pow(double[] args)
        {
            return args.Aggregate((lhs, rhs) => Math.Pow(lhs, rhs));
        }

        [Obsolete("Don't use it! Use Calculate!")]
        public double? Sum(double[] args)
        {
            SumOperation sum = new SumOperation();
            sum.Operands = args;
            return sum.Execute();
        }

        public double? Sub(double[] args)
        {
            return args.Aggregate((lhs, rhs) => lhs - rhs);
        }

        public double? New(double[] args)
        {
            return 0;
        }
    }
}
