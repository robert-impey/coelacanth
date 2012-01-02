using System;
using System.Security.Cryptography;
using System.Text;

namespace Coelacanth.Lib
{
    public class PasswordGenerator
    {
        #region Public Properties

        public bool IncludeUppercase { get; set; }
        public bool IncludeLowercase { get; set; }
        public bool IncludeDigits { get; set; }
        public int PasswordLength { get; set; }

        #endregion

        #region Private Properties

        private string AvailableCharacters
        {
            get
            {
                var availableCharacters = new StringBuilder();

                if (IncludeUppercase)
                {
                    for (var i = 'A'; i <= 'Z'; i++)
                    {
                        availableCharacters.Append(Convert.ToChar(i));
                    }
                }

                if (IncludeLowercase)
                {
                    for (var i = 'a'; i <= 'z'; i++)
                    {
                        availableCharacters.Append(Convert.ToChar(i));
                    }
                }

                if (IncludeDigits)
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
                var randomNumberGenerator = new RNGCryptoServiceProvider();
                var randomNumbers = new byte[PasswordLength];
                randomNumberGenerator.GetBytes(randomNumbers);

                foreach (var randomNumber in randomNumbers)
                {
                    newPassword.Append(availableCharacters[randomNumber % availableCharacters.Length]);
                }
            }

            return newPassword.ToString();
        }

        #endregion
    }
}
