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
            var passwordGenerator = DefaultPasswordGenerator();

            var passwordLength = 20;
            passwordGenerator.PasswordLength = passwordLength;

            var password = passwordGenerator.NewPassword();

            Assert.AreEqual(passwordLength, password.Length);
        }

        [Test]
        public void PwGenWoUcDoesNotGeneratePwWithUc()
        {
            var passwordGenerator = DefaultPasswordGenerator();

            passwordGenerator.IncludeUppercase = false;

            var password = passwordGenerator.NewPassword();

            Assert.IsFalse(Regex.IsMatch(password, "[A-Z]+"));
        }

        [Test]
        public void PwGenWoLcDoesNotGeneratePwWithLc()
        {
            var passwordGenerator = DefaultPasswordGenerator();

            passwordGenerator.IncludeLowercase = false;

            var password = passwordGenerator.NewPassword();

            Assert.IsFalse(Regex.IsMatch(password, "[a-z]+"));
        }

        [Test]
        public void PwGenWoDigitsDoesNotGeneratePwWithDigits()
        {
            var passwordGenerator = DefaultPasswordGenerator();

            passwordGenerator.IncludeDigits = false;

            var password = passwordGenerator.NewPassword();

            Assert.IsFalse(Regex.IsMatch(password, "[0-9]+"));
        }

        #endregion

        #region Helpers

        private static PasswordGenerator DefaultPasswordGenerator()
        {
            var passwordGenerator = new PasswordGenerator();

            passwordGenerator.IncludeUppercase = true;
            passwordGenerator.IncludeLowercase = true;
            passwordGenerator.IncludeDigits = true;
            passwordGenerator.PasswordLength = 20;

            return passwordGenerator;
        }

        #endregion
    }
}
