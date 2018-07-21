using IsogramProgram;
using System;
using Xunit;

namespace Isogram.Tests
{
    public class IsogramTest
    {
        [Fact]
        public void CheckForEmptyString()
        {
            Assert.True(CheckIsogram.IsIsogram(""));
        }
        [Fact]
        public void CheckForisogram()
        {
            Assert.True(CheckIsogram.IsIsogram("isogram"));
        }
        [Fact]
        public void CheckingForShortString()
        {
            Assert.False(CheckIsogram.IsIsogram("eleven"));
        }
        [Fact]
        public void CheckingForLongString()
        {
            Assert.True(CheckIsogram.IsIsogram("subdermatoglyphic"));
        }
        [Fact]
        public void CheckingForUpperLowerCase()
        {
            Assert.True(CheckIsogram.IsIsogram("Alphabet"));
        }
        [Fact]
        public void CheckingForHyphen()
        {
            Assert.True(CheckIsogram.IsIsogram("thumbscrew-japingly"));
        }
        [Fact]
        public void checkingForDoubleHyphens()
        {
            Assert.True(CheckIsogram.IsIsogram("six-year-old"));
        }
        [Fact]
        public void checkingForSingleSpaces()
        {
            Assert.True(CheckIsogram.IsIsogram("Rehan X"));
        }
        [Fact]
        public void checkingForDoubleSpaces()
        {
            Assert.True(CheckIsogram.IsIsogram("Rehan Mol X"));
        }
    }
}
