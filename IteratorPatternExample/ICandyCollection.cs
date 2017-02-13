//------------------------------------------------------------------------
// <copyright file="ICandyCollection.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace IteratorPatternExample
{
    public interface ICandyCollection
    {
        /// <summary>
        /// Creates the iterator.
        /// </summary>
        /// <returns></returns>
        JellyBeanIterator CreateIterator();
    }
}
