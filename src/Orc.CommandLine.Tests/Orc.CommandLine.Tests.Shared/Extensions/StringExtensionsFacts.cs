﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtensionsFacts.cs" company="Wild Gums">
//   Copyright (c) 2008 - 2015 Wild Gums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.CommandLine.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class StringExtensionsFacts
    {
        [TestCase("", false)]
        [TestCase("a", false)]
        [TestCase("ab", false)]
        [TestCase("-a", true)]
        [TestCase("-ab", true)]
        [TestCase("/a", true)]
        [TestCase("/ab", true)]
        public void TheIsSwitch1Method(string input, bool expectedValue)
        {
            Assert.AreEqual(expectedValue, input.IsSwitch());
        }

        [TestCase("", "-a", false)]
        [TestCase("a", "-aa", false)]
        [TestCase("aa", "-a", false)]
        [TestCase("a", "-a", true)]
        [TestCase("abc", "-abc", true)]
        [TestCase("", "/a", false)]
        [TestCase("a", "/aa", false)]
        [TestCase("aa", "/a", false)]
        [TestCase("a", "/a", true)]
        [TestCase("abc", "/abc", true)]
        public void TheIsSwitch2Method(string input, string switchValue, bool expectedValue)
        {
            Assert.AreEqual(expectedValue, input.IsSwitch(switchValue));
        }
    }
}