using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class Calc
    {
        public int Calculate(string op, int[] args)
        {
            if (op == "sum")
                return Sum(args);
            else if (op == "sub")
                return Sub(args);
            else if (op == "pow")
                return Pow(args);
            else if (op == "mul")
                return Mult(args);
            return 0;
        }

        public int Mult(int[] args)
        {
            return args.Aggregate((lhs, rhs) => lhs * rhs);
        }

        public int Pow(int[] args)
        {
            return args.Aggregate((lhs, rhs) => (int)Math.Pow((double)lhs, (double)rhs));
        }

        public int Sum(int[] args)
        {
            return args.Aggregate((lhs, rhs) => lhs + rhs);
        }

        public int Sub(int[] args)
        {
            return args.Aggregate((lhs, rhs) => lhs - rhs);
        }

        public int New(int[] args)
        {
            return 0;
        }
    }
}
