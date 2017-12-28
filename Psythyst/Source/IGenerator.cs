using System.Collections.Generic;

namespace T2rkus.Spark
{
    /// <summary>
    /// IGenerator Interface.
    /// </summary>
    public interface IGenerator<TSource, TResult> : IPriority
    {
        IEnumerable<TResult> Generate(TSource Model);
    }
}