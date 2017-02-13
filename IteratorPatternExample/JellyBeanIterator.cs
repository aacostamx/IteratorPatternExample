//------------------------------------------------------------------------
// <copyright file="JellyBeanIterator.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace IteratorPatternExample
{
    public class JellyBeanIterator : IJellyBeanIterator
    {
        /// <summary>
        /// The jelly beans
        /// </summary>
        private JellyBeanCollection jellyBeans;

        /// <summary>
        /// The current
        /// </summary>
        private int current = 0;

        /// <summary>
        /// The step
        /// </summary>
        private int step = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="JellyBeanIterator"/> class.
        /// </summary>
        /// <param name="beans">The beans.</param>
        public JellyBeanIterator(JellyBeanCollection beans)
        {
            this.jellyBeans = beans;
        }

        /// <summary>
        /// Firsts this instance.
        /// </summary>
        /// <returns></returns>
        public JellyBean First()
        {
            current = 0;
            return jellyBeans[current] as JellyBean;
        }

        /// <summary>
        /// Nexts this instance.
        /// </summary>
        /// <returns></returns>
        public JellyBean Next()
        {
            current += step;
            if (!IsDone)
                return jellyBeans[current] as JellyBean;
            else
                return null;
        }

        /// <summary>
        /// Gets the current bean.
        /// </summary>
        /// <value>
        /// The current bean.
        /// </value>
        public JellyBean CurrentBean
        {
            get { return jellyBeans[current] as JellyBean; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is done.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is done; otherwise, <c>false</c>.
        /// </value>
        public bool IsDone
        {
            get { return current >= jellyBeans.Count; }
        }
    }
}