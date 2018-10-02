using System;
using System.Linq;
using Xunit;

namespace Validator.Tests
{
    public class EmailValidatorTests
    {
        [Fact]
        public void IsValid_Returns_True_For_Valid_Email()
        {
            var underTest = new EmailValidator();

            var result = underTest.IsValid("foo@gmail.com");

            Assert.True(result.IsValid);
        }

        [Fact]
        public void IsValid_Returns_False_For_Empty_String()
        {
            var underTest = new EmailValidator();

            var result = underTest.IsValid("");

            Assert.False(result.IsValid);
        }

        [Fact]
        public void IsValid_Returns_IsRequired_Message()
        {
            var underTest = new EmailValidator();

            var result = underTest.IsValid("");

            Assert.True(result.ErrorMessages.Single() == "Email is required.");
        }
    }
}
