using System;

namespace ExceptionHandling12
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RegisterUser();
                Console.WriteLine("User registration is successful");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine("Validation Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" error : " + ex.Message);
            }

            Console.ReadKey();
        }

        public static void RegisterUser()
        {
            Console.WriteLine("User Registration");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            ValidateRegistrationInput(name, password);

        }

        public static void ValidateRegistrationInput(string name, string password)
        {
           

            if (name.Length < 6)
            {
                throw new ValidationException("Name should have at least 6 characters.");
            }

            if (password.Length < 6)
            {
                throw new ValidationException("Password should have at least 6 characters.");
            }  
        }
    }
}
