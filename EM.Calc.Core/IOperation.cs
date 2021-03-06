﻿namespace EM.Calc.Core
{
    /// <summary>
    /// Operation 
    /// </summary>
    public interface IOperation
    {
        string Name { get; }

        double[] Operands { get; set; }

        double? Execute();

        double? Result { get; }
    }
}