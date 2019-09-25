using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharpOffline.Utils
{
    public class PasswordChecker
    {
       

        public static Response CheckPassword(String password)
        {
            /**
             *Algorithm 
             * loop over string, verify that the password contains at least one upper case, one lower case char and one digit
             * return an instance of a password object with accessible fields {something like JSON} that contain the error message if any and the success message
             * 
             */
            bool containsLowerCase = false;
            bool containsUpperCase = false;
            bool containsDigits = false;

            foreach (var input in password)
            {
                if (char.IsLower(input))
                {
                     containsLowerCase = true;
                    continue;

                }
                if (char.IsUpper(input))
                {
                     containsUpperCase = true;
                    continue;
                }
                if (char.IsDigit(input))
                {
                     containsDigits = true;
                    continue;
                }
            }

            return new Response(containsLowerCase, containsUpperCase, containsDigits);

        }
    }
}