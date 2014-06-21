﻿namespace AngleSharp.DOM.Html
{
    using System;

    /// <summary>
    /// Represents the HTML base element.
    /// </summary>
    sealed class HTMLBaseElement : HTMLElement, IHtmlBaseElement
    {
        #region ctor

        /// <summary>
        /// Creates a HTML base element.
        /// </summary>
        internal HTMLBaseElement()
        {
            _name = Tags.Base;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the base URI.
        /// </summary>
        public String Href
        {
            get { return GetAttribute(AttributeNames.Href); }
            set { SetAttribute(AttributeNames.Href, value); }
        }

        /// <summary>
        /// Gets or sets the default target frame.
        /// </summary>
        public String Target
        {
            get { return GetAttribute(AttributeNames.Target); }
            set { SetAttribute(AttributeNames.Target, value); }
        }

        #endregion

        #region Internal properties

        /// <summary>
        /// Gets if the node is in the special category.
        /// </summary>
        protected internal override Boolean IsSpecial
        {
            get { return true; }
        }
        #endregion
    }
}
