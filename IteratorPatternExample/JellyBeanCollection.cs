//------------------------------------------------------------------------
// <copyright file="JellyBeanCollection.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace IteratorPatternExample
{
    using System.Collections;

    public class JellyBeanCollection : ICandyCollection
    {
        /// <summary>
        /// The items
        /// </summary>
        private ArrayList items = new ArrayList();

        /// <summary>
        /// Creates the iterator.
        /// </summary>
        /// <returns></returns>
        public JellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count
        {
            get { return items.Count; }
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Object"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.Object"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }

    }
}