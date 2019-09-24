using System;
using System.Timers;
using LearningCSharpOffline.Math;


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
                var error = 0;
                var passwordContainsLowerCase = false;
                var passwordContainsUpperCase = false;
                var passwordContainsNumber = false;


                
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
                    Console.WriteLine("Pasword Recorded.... Evaluating!!!");
                    if (userInput.Length < 8)
                    {
                        string message =  "Errors Detected : ";
                        error += 1;
                        Console.WriteLine(message + error  + " => Password Must be 8 characters or Longer!!");
                        isUserInSession = false;
                    }else {
                        
                        //the string must contain at least one number
                        // must contain at least at least one upper case 
                        // must Contain at least one lower case
                        /*
                         *algorithm
                         * iterate through each character in the string
                         * if one character is already lower case, 
                         */
                        foreach(var instance in userInput)
                        {
                            
                          if (instance.GetType() == typeof(char) && char.IsLower(instance))
                           {
                                    passwordContainsLowerCase = true;
                                    continue;
                            }

                            if (instance.GetType()== typeof(char) && char.IsUpper(instance))
                            {
                                passwordContainsUpperCase = true;
                                continue;
                            }


                            if (instance.GetType() == typeof(char) && char.IsDigit(instance))
                            {
                                passwordContainsNumber = true;
                            }                          

                        }
                        
                        if(passwordContainsLowerCase && passwordContainsNumber && passwordContainsUpperCase)
                        {
                            Console.WriteLine("Congratulations!! your password has passed the tests and can be used");
                            isUserInSession = false;
                        }
                        else
                        {
                            string message = "Errors Detected : ";

                            if (!passwordContainsUpperCase)
                            {
                                error += 1;
                                Console.WriteLine(message + error   + " => Password must contain at least one upper case character");
                                isUserInSession = false;
                            }  if(!passwordContainsLowerCase){
                                error += 1;
                                Console.WriteLine(message + error +   " => Password must contain at least one lower case character");
                                isUserInSession = false;
                            }
                             if (!passwordContainsNumber)
                            {
                                error += 1;
                                Console.WriteLine(message + error + "=> Password must contain at least one digit");
                                isUserInSession = false;
                            }
                            Console.WriteLine("Total number of Errors: " + error);
                        }
                    }

                }
            }
        }
    }
    
}
