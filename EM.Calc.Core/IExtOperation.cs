using System;

namespace EM.Calc.Core
{
    public interface IExtOperation : IOperation
    {
        /// <summary>
        /// Unique identificator
        /// </summary>
        Guid Uid { get; }

        /// <summary>
        /// Operation description
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Agruments count
        /// </summary>
        int? ArgCount { get; }
    }
}
