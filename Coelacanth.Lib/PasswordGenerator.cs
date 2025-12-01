using System.Security.Cryptography;
using System.Text;

namespace Coelacanth.Lib
{
    public class PasswordGenerator
    {
        private readonly string availableCharacters;
        private readonly int passwordLength;

        internal PasswordGenerator(string availableCharacters, int passwordLength)
        {
            this.availableCharacters = availableCharacters;
            this.passwordLength = passwordLength;
        }

        public string NewPassword()
        {
            var newPassword = new StringBuilder();

            if (availableCharacters.Length > 0)
            {
                var randomNumbers = new byte[passwordLength];
                RandomNumberGenerator.Fill(randomNumbers);

                foreach (var randomNumber in randomNumbers)
                {
                    newPassword.Append(availableCharacters[randomNumber % availableCharacters.Length]);
                }
            }

            return newPassword.ToString();
        }
    }
}
