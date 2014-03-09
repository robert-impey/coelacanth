using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coelacanth.Lib
{
    public class PasswordGeneratorBuilder
    {
        public bool IncludeUppercase { get; set; }
        public bool IncludeLowercase { get; set; }
        public bool IncludeDigits { get; set; }
        public int PasswordLength { get; set; }

        private static StringBuilder GetUppercase()
        {
            var uppercase = new StringBuilder();

            for (var i = 'A'; i <= 'Z'; i++)
            {
                uppercase.Append(Convert.ToChar(i));
            }

            return uppercase;
        }

        private static StringBuilder GetLowercase()
        {
            var lowercase = new StringBuilder();

            for (var i = 'a'; i <= 'z'; i++)
            {
                lowercase.Append(Convert.ToChar(i));
            }

            return lowercase;
        }

        private static StringBuilder GetDigits()
        {
            var digits = new StringBuilder();

            for (var i = 0; i <= 9; i++)
            {
                digits.Append(i);
            }

            return digits;
        }

        public PasswordGenerator Build()
        {
            var availableCharacters = new StringBuilder();

            if (IncludeUppercase)
            {
                
                    availableCharacters.Append(GetUppercase());
            }

            if (IncludeLowercase)
            {
                availableCharacters.Append(GetUppercase());
            }

            if (IncludeDigits)
            {
                availableCharacters.Append(GetUppercase());
            }

            return new PasswordGenerator(availableCharacters.ToString(), PasswordLength);
        }
    }
}
