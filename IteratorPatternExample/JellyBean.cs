//------------------------------------------------------------------------
// <copyright file="JellyBean.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace IteratorPatternExample
{
    public class JellyBean
    {
        /// <summary>
        /// Gets or sets the flavor.
        /// </summary>
        /// <value>
        /// The flavor.
        /// </value>
        public string flavor { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JellyBean"/> class.
        /// </summary>
        /// <param name="flavor">The flavor.</param>
        public JellyBean(string flavor)
        {
            this.flavor = flavor;
        }
    }
}
