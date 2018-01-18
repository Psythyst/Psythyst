using System.Collections.Generic;

namespace Psythyst
{
    /// <summary>
    /// IPostProcessor Interface.
    /// </summary>
    public interface IPostProcessor<TResult> : IPriority
    {
        IEnumerable<TResult> Process(IEnumerable<TResult> Collection);
    }
}