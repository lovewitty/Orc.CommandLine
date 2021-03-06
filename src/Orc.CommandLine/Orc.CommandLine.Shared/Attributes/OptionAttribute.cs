﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OptionAttribute.cs" company="Wild Gums">
//   Copyright (c) 2008 - 2015 Wild Gums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.CommandLine
{
    using System;

    [AttributeUsage(AttributeTargets.Property)]
    public class OptionAttribute : Attribute
    {
        public OptionAttribute(char shortName, string longName)
        {
            ShortName = shortName;
            LongName = longName;
            AcceptsValue = true;
            TrimQuotes = true;
            IsMandatory = false;
        }

        public char ShortName { get; private set; }

        public string LongName { get; private set; }

        public string DisplayName { get; set; }

        public string HelpText { get; set; }

        public bool AcceptsValue { get; set; }

        public bool TrimQuotes { get; set; }

        public bool IsMandatory { get; set; }
    }
}