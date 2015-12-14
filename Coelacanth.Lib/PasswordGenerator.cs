using System;
using System.Security.Cryptography;
using System.Text;

namespace Coelacanth.Lib
{
    public class PasswordGenerator : IDisposable
    {
        #region private fields

        private readonly string availableCharacters;
        private readonly int passwordLength;
        private RNGCryptoServiceProvider randomNumberGenerator;

        #endregion

        private PasswordGenerator()
        {
        }

        internal PasswordGenerator(string availableCharacters, int passwordLength)
        {
            this.availableCharacters = availableCharacters;
            this.passwordLength = passwordLength;
            this.randomNumberGenerator = new RNGCryptoServiceProvider();
        }

        #region Public Methods

        public string NewPassword()
        {
            var newPassword = new StringBuilder();

            if (availableCharacters.Length > 0)
            {
                var randomNumbers = new byte[passwordLength];
                randomNumberGenerator.GetBytes(randomNumbers);

                foreach (var randomNumber in randomNumbers)
                {
                    newPassword.Append(availableCharacters[randomNumber % availableCharacters.Length]);
                }
            }

            return newPassword.ToString();
        }

        #endregion

        public void Dispose()
        {
            this.randomNumberGenerator.Dispose();
        }
    }
}
