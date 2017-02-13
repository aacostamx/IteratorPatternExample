//------------------------------------------------------------------------
// <copyright file="IJellyBeanIterator.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace IteratorPatternExample
{
    public interface IJellyBeanIterator
    {
        /// <summary>
        /// Firsts this instance.
        /// </summary>
        /// <returns></returns>
        JellyBean First();

        /// <summary>
        /// Nexts this instance.
        /// </summary>
        /// <returns></returns>
        JellyBean Next();

        /// <summary>
        /// Gets a value indicating whether this instance is done.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is done; otherwise, <c>false</c>.
        /// </value>
        bool IsDone { get; }

        /// <summary>
        /// Gets the current bean.
        /// </summary>
        /// <value>
        /// The current bean.
        /// </value>
        JellyBean CurrentBean { get; }
    }
}