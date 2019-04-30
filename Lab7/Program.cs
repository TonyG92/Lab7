using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {

        static void Main(string[] args)
        {
            string email;
            string name;
            string number;
            string date;

            //Name 
            Console.WriteLine("Please Enter a valid name: ");
            name = Console.ReadLine();

            try
            {
                bool isNameValid = ValidateName(name);

                if (isNameValid)
                {
                    Console.WriteLine("Name is valid! ");
                }
                else
                {
                    throw new Exception("This is not a valid name! ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Email
            Console.WriteLine("Please Enter a valid email: ");
            email = Console.ReadLine();

            try
            {
                bool isEmailValid = ValidateEmail(email);

                if (isEmailValid)
                {
                    Console.WriteLine("Email is valid! ");
                }
                else
                {
                    throw new Exception("This is not a valid email");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Phone Number
            Console.WriteLine("Please Enter a valid number: ");
            number = Console.ReadLine();

            try
            {
                bool isPhoneValid = ValidatePhone(number);

                if (isPhoneValid)
                {
                    Console.WriteLine("Number is valid! ");
                }
                else
                {
                    throw new Exception("This is not a valid number");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Date
            Console.WriteLine("Please Enter a valid date: ");
            date = Console.ReadLine();

            try
            {
                bool isDateValid = ValidateDate(date);

                if (isDateValid)
                {
                    Console.WriteLine("Date is valid! ");
                }
                else
                {
                    throw new Exception("This is not a valid date");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool ValidateEmail(string email)
        {
            bool regexVariable = Regex.IsMatch(email, @"([a-zA-Z_0-9\.\-]){5,30}(@)([a-zA-Z_0-9\.\-]){5,10}(.)([a-zA-Z_0-9\.\-]){2,3}");

            return regexVariable;
        }

        public static bool ValidateName(string name)
        {
            bool regexName = Regex.IsMatch(name, @"\b([A-Z][a-z]{1,30})\b");

            return regexName;
        }
        public static bool ValidatePhone(string number)
        {
            bool regexNumber = Regex.IsMatch(number, @"([0-9]{3})\-[0-9]{3}\-[0-9]{4}");

            return regexNumber;
        }

        public static bool ValidateDate(string date)
        {
            bool regexDate = Regex.IsMatch(date, @"(([0-3]{1})([0-9]{1})(/)([0-1]{1})([0-9]{1})(/)([0-9]){4})");

            return regexDate;
        }

    }
}