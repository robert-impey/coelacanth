using System.Security.Cryptography;
using System.Text;

namespace Coelacanth.Lib
{
    public class PasswordGenerator
    {
        #region private fields

        private readonly string availableCharacters;
        private readonly int passwordLength;

        #endregion

        private PasswordGenerator()
        {
        }

        internal PasswordGenerator(string availableCharacters, int passwordLength)
        {
            this.availableCharacters = availableCharacters;
            this.passwordLength = passwordLength;
        }

        #region Public Methods

        public string NewPassword()
        {
            var newPassword = new StringBuilder();

            if (availableCharacters.Length > 0)
            {
                using (var randomNumberGenerator = new RNGCryptoServiceProvider())
                {
                    var randomNumbers = new byte[passwordLength];
                    randomNumberGenerator.GetBytes(randomNumbers);

                    foreach (var randomNumber in randomNumbers)
                    {
                        newPassword.Append(availableCharacters[randomNumber % availableCharacters.Length]);
                    }
                }
            }

            return newPassword.ToString();
        }

        #endregion
    }
}
