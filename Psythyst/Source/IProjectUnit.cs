using System;
using System.Collections.Generic;

namespace T2rkus.Spark
{
    /// <summary>
    /// IProjectUnit Interface.
    /// </summary>
    public interface IProjectUnit<TSource, TResult>
    {
        IProjectUnit<TSource, TResult> AddGenerator(IGenerator<TSource, TResult> Generator, bool Condition = true);
        IProjectUnit<TSource, TResult> AddGeneratorCollection(IEnumerable<IGenerator<TSource, TResult>> Collection, bool Condition = true);


        IProjectUnit<TSource, TResult> AddPostProcessor(IPostProcessor<TResult> PostProcessor, bool Condition = true);
        IProjectUnit<TSource, TResult> AddPostProcessorCollection(IEnumerable<IPostProcessor<TResult>> Collection, bool Condition = true);


        IEnumerable<TResult> RunGenerator(TSource Model, Action<IGenerator<TSource, TResult>, Exception> OnError = null);
        IEnumerable<TResult> RunPostProcessor(IEnumerable<TResult> Collection, Action<IPostProcessor<TResult>, Exception> OnError = null);
        IEnumerable<TResult> Run(TSource Model, Action<IGenerator<TSource, TResult>, Exception> OnGeneratorError = null, Action<IPostProcessor<TResult>, Exception> OnPostProcessorError = null);
    }
}