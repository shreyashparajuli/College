using System;

namespace ConsoleApplication1
{
    class Class1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Get user input for gender, height, and weight
                Console.WriteLine("Enter your gender (M/F): ");
                string gender = Console.ReadLine().ToUpper();

                Console.WriteLine("Enter your weight (in kilograms): ");
                float weight = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter your height (in meters): ");
                float height = float.Parse(Console.ReadLine());

                // Calculate BMI using the metric formula
                float bmi = weight / (height * height);

                // Display the BMI value
                Console.WriteLine("Your BMI is: " + bmi);

                // Determine BMI category based on gender and BMI
                if (gender == "M")
                {
                    if (bmi < 18.5)
                        Console.WriteLine("You are underweight.");
                    else if (bmi >= 18.5 && bmi < 25)
                        Console.WriteLine("You are in the normal range.");
                    else if (bmi >= 25 && bmi < 30)
                        Console.WriteLine("You are overweight.");
                    else
                        Console.WriteLine("You are obese.");
                }
                else if (gender == "F")
                {
                    if (bmi < 17.5)
                        Console.WriteLine("You are underweight.");
                    else if (bmi >= 17.5 && bmi < 24)
                        Console.WriteLine("You are in the normal range.");
                    else if (bmi >= 24 && bmi < 30)
                        Console.WriteLine("You are overweight.");
                    else
                        Console.WriteLine("You are obese.");
                }

                // Ask if the user wants to calculate again
                Console.WriteLine("Do you want to calculate again? (Y/N): ");
                string response = Console.ReadLine().ToUpper();
                if (response != "Y")
                {
                    break;
                }
            }
        }
    }
}
