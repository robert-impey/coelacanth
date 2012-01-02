using Coelacanth.Lib;
using NUnit.Framework;

namespace Coelacanth.Test
{
    [TestFixture]
    public class PasswordGeneratorTest
    {
        [Test]
        public void GeneratePassword()
        {
            var passwordGenerator = new PasswordGenerator();

            passwordGenerator.IncludeUppercase = true;
            passwordGenerator.IncludeLowercase = true;
            passwordGenerator.IncludeDigits = true;

            var passwordLength = 20;
            passwordGenerator.PasswordLength = passwordLength;

            var password = passwordGenerator.NewPassword();

            Assert.AreEqual(passwordLength, password.Length);
        }
    }
}
