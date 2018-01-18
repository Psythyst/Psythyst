using System.Collections.Generic;

namespace Psythyst
{
    /// <summary>
    /// IGenerator Interface.
    /// </summary>
    public interface IGenerator<TSource, TResult> : IPriority
    {
        IEnumerable<TResult> Generate(TSource Model);
    }
}