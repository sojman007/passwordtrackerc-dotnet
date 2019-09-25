using System;
//using System.Timers;
using LearningCSharpOffline.Utils;


namespace LearningCSharpOffline
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Password Checker 
             * tells if you have created a valid password or not
             */
            var isUserInSession = true;

            while (isUserInSession)
            {
                Console.WriteLine("Welcome To Password Checker v.1 ");
                Console.WriteLine(" your number one tool for checking password integrity and strength");
                Console.Write(" Type In a Password: ");
                string userInput = Console.ReadLine();
                if (String.IsNullOrEmpty(userInput) || String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Please Enter a Valid Input! Enter E to exit");
                    string nextInput = Console.ReadLine();
                    if ( !String.IsNullOrEmpty(nextInput) && nextInput.ToLower() == "e")
                    {
                        isUserInSession = false;
                    }

                }
                else
                {
                    Console.WriteLine("Pasword Recorded. Now Evaluating...");
                    if (userInput.Length < 8)
                    {
                        string message =  "Error: ";
                       
                        Console.WriteLine(message  + " Password Must be 8 characters or Longer!!");
                        isUserInSession = false;
                    }else {

                       var Response =  PasswordChecker.CheckPassword(userInput);
                        if (!Response.passwordContainsLowerCase || !Response.passwordContainsNumber || !Response.passwordContainsUpperCase)
                        {

                            Console.WriteLine("Evaluation Complete");
                            Console.WriteLine("All error messages:  *" + Response.ErrorMessages[0] +", * "+ Response.ErrorMessages[1] + ",  *"+ Response.ErrorMessages[2]);
                            isUserInSession = false;
                        }
                        else
                        {
                            Console.WriteLine("Evaluation Complete");
                            Console.WriteLine(Response.SuccessMessage);
                            isUserInSession = false;
                        }
                    }

                }
            }
        }
    }
    
}
