using System;
using Xunit;

namespace LongestWord.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("fun&!! time", "time")]
        [InlineData("I love dogs", "love")]
        [InlineData("time", "time")]
        [InlineData("Hello world123 567", "world123")]
        [InlineData("fun&!! ,t,i,m,e,", "time")]
        public void LongestWord_WhenCalled_ShouldReturnLongestWord(string sentence, string expected)
        {
            string result = Program.LongestWord(sentence);
            Assert.Equal(expected, result);
        }
    }
}
