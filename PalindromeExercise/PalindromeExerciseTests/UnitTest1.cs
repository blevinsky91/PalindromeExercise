using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("sandwich", false)]
        [InlineData("A man, a plan, a canal - Panama!", true)]
        public void PalindromeTest(string args, bool expected)
        {
            //Arrange
            //Instantiate an object

            WordSmith word = new WordSmith();

            //Act
            //Call method and assign to variable

            var actual = WordSmith.IsAPalindrome(args);

            //Assert
            //Compare

            Assert.Equal(expected, actual);
        }
    }
}
