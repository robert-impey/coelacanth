using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coelacanth.Lib
{
    public class PasswordGenerator
    {
        #region Properties

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
            var newPassword = new StringBuilder();

            // Make the string of the available characters.
            var availableCharacters = AvailableCharacters;

            // Make the password.
            if (availableCharacters.Length > 0)
            {
                var random = new Random();
                for (var i = 0; i < PasswordLength; i++)
                {
                    var randomIndex = random.Next(0, availableCharacters.Length);
                    newPassword.Append(Convert.ToChar(availableCharacters[randomIndex]));
                }
            }

            return newPassword.ToString();
        }

        #endregion
    }
}
