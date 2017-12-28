using System.Collections.Generic;

namespace T2rkus.Spark
{
    /// <summary>
    /// IPostProcessor Interface.
    /// </summary>
    public interface IPostProcessor<TResult> : IPriority
    {
        IEnumerable<TResult> Process(IEnumerable<TResult> Collection);
    }
}