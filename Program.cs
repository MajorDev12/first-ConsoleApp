using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First 
            /*Console.WriteLine("How old are you?");
            int age = Console.ReadLine();

            if(age < 18)
            {
                Console.WriteLine("Not yet");
            }else if(age == 18)
            {
                Console.WriteLine("So you just turned 18?");
                string answer = Console.ReadLine();

                if(answer == "yes")
                {
                    Console.WriteLine("We cant help you");
                }else if(answer == "no")
                {
                    Console.WriteLine("Welcome to the big boyz");
                }
                else
                {
                    Console.WriteLine("enter yes or no");
                }
            }else
            {
                Console.WriteLine("Welcome to the big boyz");
            }*/



            // second

            //Console.WriteLine("How old are you?");
            //string age = Console.ReadLine();
            //int ageInt = Convert.ToInt16(age);

            /* if (ageInt < 18)
             {
                 Console.WriteLine("you are under age");
                 string answer = Console.ReadLine();

                 // Using case-insensitive comparison for better user experience
                 if (answer.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                 {
                     Console.WriteLine("We can't help you");
                 }
                 else if (answer.Equals("No", StringComparison.OrdinalIgnoreCase))
                 {
                     Console.WriteLine("Congrats, You can now join the big boys");
                 }

             }
             else if(ageInt == 18)
             {
                 Console.WriteLine("So you Just turned 18...still a little boy");
             }
             else
             {
                 Console.WriteLine("over 18");
             }*/



            // third code
            /*Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            try
            {
                int ageInt = Convert.ToInt16(age);

                if (ageInt < 18)
                {
                    Console.WriteLine("you are under age");
                    Console.WriteLine("Do you have parental consent? (Yes/No)");
                    string answer = Console.ReadLine();

                    // Using case-insensitive comparison for better user experience
                    if (answer.Equals("No", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("We can't help you");
                    }
                    else if (answer.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Congrats, You can now join the big boys");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please answer Yes or No.");
                    }
                }
                else if (ageInt == 18)
                {
                    Console.WriteLine("So you just turned 18... still a little boy");
                }
                else
                {
                    Console.WriteLine("Over 18");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age format. Please enter a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Age is too large or too small. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }*/


            // fourth
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            int age;

            // Use int.TryParse to safely convert the input to an integer.
            if (int.TryParse(input, out age))
            {
                if (age < 18)
                {
                    Console.WriteLine("You are under age");
                    Console.WriteLine("Do you have parental consent? (Yes/No)");
                    string answer = Console.ReadLine();

                    // Using case-insensitive comparison for better user experience
                    if (answer.Equals("No", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("We can't help you");
                    }
                    else if (answer.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Congrats, You can now join the big boys");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please answer Yes or No.");
                    }
                }
                else if (age == 18)
                {
                    Console.WriteLine("So you just turned 18... still a little boy");
                }
                else
                {
                    Console.WriteLine("Over 18");
                }
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid number.");
            }


        }
    }
}
