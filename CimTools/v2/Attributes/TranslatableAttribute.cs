﻿using System;

namespace CimTools.v2.Attributes
{
    /// <summary>
    /// Translates the specified field into the value denoted by the identifier
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class TranslatableAttribute : Attribute
    {
        /// <summary>
        /// The translation ID
        /// </summary>
        public string identifier = "";

        private TranslatableAttribute()
        {
        }

        /// <summary>
        /// Translates the specified field into the value denoted by the identifier
        /// </summary>
        /// <param name="identifier">The translation ID</param>
        public TranslatableAttribute(string identifier)
        {
            this.identifier = identifier;
        }
    }
}