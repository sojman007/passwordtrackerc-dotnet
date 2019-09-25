namespace LearningCSharpOffline.Utils
{
    public class Response
    {
        public string[] ErrorMessages;
        public string SuccessMessage;
        public bool passwordContainsLowerCase = false;
        public bool passwordContainsUpperCase = false;
        public bool passwordContainsNumber = false;
        

         public Response(bool containsLower, bool containsUpper, bool containsDigits)
        {
            ErrorMessages = new string[3];
            passwordContainsLowerCase = containsLower;
            passwordContainsNumber = containsDigits;
            passwordContainsUpperCase = containsUpper;
            if (!passwordContainsUpperCase)
            {
                var upperCaseError = "Password does not contain at least one upper case character";
                ErrorMessages[0] = upperCaseError;
            }
            if (!passwordContainsNumber)
            {
          //      errorIndex += 1;
                var digitError = "Password does not contain at least one digit";
                ErrorMessages[1] = digitError;
            }
            if (!passwordContainsLowerCase)
            {
            //    errorIndex += 1;
                var lowerCaseError = "Password does not contain at least one lower case character";
                ErrorMessages[2] = lowerCaseError;
            }
            if(passwordContainsUpperCase && passwordContainsNumber && passwordContainsLowerCase)
            {
                SuccessMessage = "Congratulations!!! your password has passed the criteria for password integrity. You can use it";
            }
        }

    }
}