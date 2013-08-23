using System;
using System.Security.Cryptography;
using System.Text;

namespace Coelacanth.Lib
{
    public class PasswordGenerator
    {
        #region private fields

        readonly bool includeUppercase;
        readonly bool includeLowercase;
        readonly bool includeDigits;
        readonly int passwordLength;

        #endregion

        public PasswordGenerator(bool includeUppercase, bool includeLowercase, 
            bool includeDigits, int passwordLength)
        {
            this.includeUppercase = includeUppercase;
            this.includeLowercase = includeLowercase;
            this.includeDigits = includeDigits;
            this.passwordLength = passwordLength;
        }

        #region Private Properties

        private string AvailableCharacters
        {
            get
            {
                var availableCharacters = new StringBuilder();

                if (includeUppercase)
                {
                    for (var i = 'A'; i <= 'Z'; i++)
                    {
                        availableCharacters.Append(Convert.ToChar(i));
                    }
                }

                if (includeLowercase)
                {
                    for (var i = 'a'; i <= 'z'; i++)
                    {
                        availableCharacters.Append(Convert.ToChar(i));
                    }
                }

                if (includeDigits)
                {
                    for (var i = 0; i <= 9; i++)
                    {
                        availableCharacters.Append(i);
                    }
                }

                return availableCharacters.ToString();
            }
        }

        #endregion

        #region Public Methods

        public string NewPassword()
        {
            return NewPassword(AvailableCharacters);
        }

        public string NewPassword(string availableCharacters)
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
