using Coelacanth.Lib;
using Xunit;
using Shouldly;
using System.Text.RegularExpressions;

namespace Coelacanth.Test
{
    public class PasswordGeneratorTest
    {
        private const int PasswordLength = 20;

        [Fact]
        public void PwGenGeneratesPwOfCorrectLength()
        {
            // Arrange
            var passwordGeneratorBuilder = new PasswordGeneratorBuilder
            {
                IncludeUppercase = true,
                IncludeLowercase = true,
                IncludeDigits = true,
                PasswordLength = PasswordLength
            };

            var passwordGenerator = passwordGeneratorBuilder.Build();

            // Act
            var password = passwordGenerator.NewPassword();

            // Assert: Assert.AreEqual(expected, actual) becomes actual.ShouldBe(expected)
            password.Length.ShouldBe(PasswordLength);
        }

        [Fact]
        public void PwGenWoUcDoesNotGeneratePwWithUc()
        {
            // Arrange
            var passwordGeneratorBuilder = new PasswordGeneratorBuilder
            {
                IncludeUppercase = false,
                IncludeLowercase = true,
                IncludeDigits = true,
                PasswordLength = PasswordLength
            };

            var passwordGenerator = passwordGeneratorBuilder.Build();

            // Act
            var password = passwordGenerator.NewPassword();

            Regex.IsMatch(password, "[A-Z]+").ShouldBeFalse();
        }

        [Fact]
        public void PwGenWoLcDoesNotGeneratePwWithLc()
        {
            // Arrange
            var passwordGeneratorBuilder = new PasswordGeneratorBuilder
            {
                IncludeUppercase = true,
                IncludeLowercase = false,
                IncludeDigits = true,
                PasswordLength = PasswordLength
            };

            var passwordGenerator = passwordGeneratorBuilder.Build();

            // Act
            var password = passwordGenerator.NewPassword();

            // Assert: Assert.IsFalse(condition) becomes condition.ShouldBeFalse()
            Regex.IsMatch(password, "[a-z]+").ShouldBeFalse();
        }

        [Fact]
        public void PwGenWoDigitsDoesNotGeneratePwWithDigits()
        {
            // Arrange
            var passwordGeneratorBuilder = new PasswordGeneratorBuilder
            {
                IncludeUppercase = true,
                IncludeLowercase = true,
                IncludeDigits = false,
                PasswordLength = PasswordLength
            };

            var passwordGenerator = passwordGeneratorBuilder.Build();

            // Act
            var password = passwordGenerator.NewPassword();

            // Assert: Assert.IsFalse(condition) becomes condition.ShouldBeFalse()
            Regex.IsMatch(password, "[0-9]+").ShouldBeFalse();
        }
    }
}