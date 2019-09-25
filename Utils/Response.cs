namespace LearningCSharpOffline.Utils
{
    public class Response
    {
        private readonly string[] errorMessages;

        public string[] GetErrorMessages() => errorMessages;

        private string successMessage;

        public string GetSuccessMessage()
        {
            return successMessage;
        }

        private void SetSuccessMessage(string value)
        {
            successMessage = value;
        }

        public readonly bool passwordContainsLowerCase = false;
        public readonly bool passwordContainsUpperCase = false;
        public readonly bool passwordContainsNumber = false;


        public Response(bool containsLower, bool containsUpper, bool containsDigits)
        {
            errorMessages = (new string[3]);
            passwordContainsLowerCase = containsLower;
            passwordContainsNumber = containsDigits;
            passwordContainsUpperCase = containsUpper;
            if (!passwordContainsUpperCase)
            {
                var upperCaseError = "Password does not contain at least one upper case character";
                GetErrorMessages()[0] = upperCaseError;
            }
            if (!passwordContainsNumber)
            {
          //      errorIndex += 1;
                var digitError = "Password does not contain at least one digit";
                GetErrorMessages()[1] = digitError;
            }
            if (!passwordContainsLowerCase)
            {
            //    errorIndex += 1;
                var lowerCaseError = "Password does not contain at least one lower case character";
                GetErrorMessages()[2] = lowerCaseError;
            }
            if(passwordContainsUpperCase && passwordContainsNumber && passwordContainsLowerCase)
            {
                SetSuccessMessage("Congratulations!!! your password has passed the criteria for password integrity. You can use it");
            }
        }

    }
}