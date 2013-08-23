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
            var passwordGenerator = new PasswordGenerator(true, true, true, passwordLength);

            var password = passwordGenerator.NewPassword();

            Assert.AreEqual(passwordLength, password.Length);
        }

        [Test]
        public void PwGenWoUcDoesNotGeneratePwWithUc()
        {
            var passwordGenerator = new PasswordGenerator(false, true, true, 20);

            var password = passwordGenerator.NewPassword();

            Assert.IsFalse(Regex.IsMatch(password, "[A-Z]+"));
        }

        [Test]
        public void PwGenWoLcDoesNotGeneratePwWithLc()
        {
            var passwordGenerator = new PasswordGenerator(true, false, true, 20);

            var password = passwordGenerator.NewPassword();

            Assert.IsFalse(Regex.IsMatch(password, "[a-z]+"));
        }

        [Test]
        public void PwGenWoDigitsDoesNotGeneratePwWithDigits()
        {
            var passwordGenerator = new PasswordGenerator(true, true, false, 20);

            var password = passwordGenerator.NewPassword();

            Assert.IsFalse(Regex.IsMatch(password, "[0-9]+"));
        }

        [Test]
        public void PwGenGivenCharsDoesNotGeneratePwWithOtherChars()
        {
            var passwordGenerator = new PasswordGenerator(false, false, false, 1);

            var givenCharacters = "ABCDE";

            var password = passwordGenerator.NewPassword(givenCharacters);

            Assert.IsTrue(Regex.IsMatch(password, "[A-E]"));
        }

        #endregion

        #region Helpers

        private static PasswordGenerator DefaultPasswordGenerator()
        {
            var passwordGenerator = new PasswordGenerator(true, true, true, 20);

            return passwordGenerator;
        }

        #endregion
    }
}
