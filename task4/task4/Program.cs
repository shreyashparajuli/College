using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the BMI Calculator!");

                // Get gender input
                Console.WriteLine("Enter your gender (male/female): ");
                string gender = Console.ReadLine().ToLower();

                // Get weight in kilograms
                Console.WriteLine("Enter your weight in kilograms: ");
                double weight = double.Parse(Console.ReadLine());

                // Get height in meters
                Console.WriteLine("Enter your height in meters: ");
                double height = double.Parse(Console.ReadLine());

                // BMI calculation for metric system
                double bmi = weight / (height * height);

                // Display the BMI and category based on gender
                Console.WriteLine($"Your BMI is: {bmi:F2}");
                DisplayBMIResult(bmi, gender);

                // Ask if they want to calculate again
                Console.WriteLine("Would you like to calculate again? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }
        }

        // Method to display the BMI category based on gender
        static void DisplayBMIResult(double bmi, string gender)
        {
            if (gender == "female")
            {
                string category = bmi < 17.5 ? "severely underweight" :
                                  bmi < 19.1 ? "underweight" :
                                  bmi < 25.8 ? "in normal range" :
                                  bmi < 27.3 ? "marginally overweight" :
                                  bmi < 32.3 ? "overweight" :
                                  bmi < 35 ? "very overweight or obese" :
                                  bmi < 40 ? "severely obese" :
                                  bmi < 50 ? "morbidly obese" : "super obese";

                Console.WriteLine($"As a woman, you are {category}.");
            }
            else if (gender == "male")
            {
                string category = bmi < 18.5 ? "severely underweight" :
                                  bmi < 20.7 ? "underweight" :
                                  bmi < 26.4 ? "in normal range" :
                                  bmi < 27.8 ? "marginally overweight" :
                                  bmi < 31.1 ? "overweight" :
                                  bmi < 35 ? "very overweight or obese" :
                                  bmi < 40 ? "severely obese" :
                                  bmi < 50 ? "morbidly obese" : "super obese";

                Console.WriteLine($"As a man, you are {category}.");
            }
            else
            {
                Console.WriteLine("Invalid gender input.");
            }
        }
    }
}
