using Coelacanth.Lib;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace Coelacanth.Test
{
    [TestFixture]
    public class PasswordGeneratorTest
    {
        #region Tests

        [Test]
        public void PwGenGeneratesPwOfCorrectLength()
        {
            var passwordLength = 20;
            var passwordGeneratorBuilder = new PasswordGeneratorBuilder
                {
                    IncludeUppercase = true,
                    IncludeLowercase = true,
                    IncludeDigits = true,
                    PasswordLength = passwordLength
                };

            var passwordGenerator = passwordGeneratorBuilder.Build();

            var password = passwordGenerator.NewPassword();

            Assert.AreEqual(passwordLength, password.Length);
        }

        [Test]
        public void PwGenWoUcDoesNotGeneratePwWithUc()
        {
            var passwordGeneratorBuilder = new PasswordGeneratorBuilder
            {
                IncludeUppercase = false,
                IncludeLowercase = true,
                IncludeDigits = true,
                PasswordLength = 20
            };

            var passwordGenerator = passwordGeneratorBuilder.Build();

            var password = passwordGenerator.NewPassword();

            Assert.IsFalse(Regex.IsMatch(password, "[A-Z]+"));
        }

        [Test]
        public void PwGenWoLcDoesNotGeneratePwWithLc()
        {
            var passwordGeneratorBuilder = new PasswordGeneratorBuilder
            {
                IncludeUppercase = true,
                IncludeLowercase = false,
                IncludeDigits = true,
                PasswordLength = 20
            };

            var passwordGenerator = passwordGeneratorBuilder.Build();

            var password = passwordGenerator.NewPassword();

            Assert.IsFalse(Regex.IsMatch(password, "[a-z]+"));
        }

        [Test]
        public void PwGenWoDigitsDoesNotGeneratePwWithDigits()
        {
            var passwordGeneratorBuilder = new PasswordGeneratorBuilder
            {
                IncludeUppercase = true,
                IncludeLowercase = true,
                IncludeDigits = false,
                PasswordLength = 20
            };

            var passwordGenerator = passwordGeneratorBuilder.Build();

            var password = passwordGenerator.NewPassword();

            Assert.IsFalse(Regex.IsMatch(password, "[0-9]+"));
        }

        #endregion
    }
}
