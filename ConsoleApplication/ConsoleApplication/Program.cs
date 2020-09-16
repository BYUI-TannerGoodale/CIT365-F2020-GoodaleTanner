using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            // OVERVIEW
            // This application will follow the following tasks.
            // 1. The user will be propted for their name and location, which will be echoed back to them.
            // 2. The program will output the current date, not including the time.
            // 3. The program will output the number of days until Christmas of this year.
            // 4. The program will intergrate Rob Mill's Glazing application with minor adjustments.
            // All propmts and outputs will have appropriate text labels.
            // The program will pause in the console between tasks.
            // There will be no input validation for this program.
            Greet();
            DateNoTime();
            DaysToXmas();
            GlazerCalc();
        }

        // This method will preform the first task.
        static void Greet()
        {
            // Greet user and ask for name.
            Console.WriteLine("What's your name?");
            // Create a string variable and store the user's name in it.
            string userName = Console.ReadLine();
            // Respond intelligently.
            Console.WriteLine($"{userName}, got it.");
            // Prompt user for their location.
            Console.WriteLine("Where are you from?");
            // Create a string variable to store the user's location.
            string userLocation = Console.ReadLine();
            // Output the user's location intelligently then echo both in a statement.
            Console.WriteLine($"{userLocation} eh? I think I've heard of it before.");
            Console.WriteLine($"{userName} from {userLocation}. You should be good to go on in now.");
            // Pause console until user enters a keystroke.
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            // End of task one.
        }

        //This method will preform the second task.
        static void DateNoTime()
        {
            // Define the current date and stringify it in a variable.
            DateTime currentDate = DateTime.Now;
            string date = currentDate.ToString("MMMM dd yyyy");
            // Output the current date intelligently.
            Console.WriteLine($"As a reminder to all workers, the current date is {date}.");
            // Pause console until user enters a keystroke.
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            // End of task two.
        }

        //This method will preform the third task.
        static void DaysToXmas()
        {
            // Define the current date.
            DateTime currentDate = DateTime.Now;
            // Define the date for Christmas this year.
            DateTime xMas = new DateTime(2020, 12, 25);
            // Find the difference between the two dates using TimeSpan.
            TimeSpan diff = xMas.Subtract(currentDate);
            // Put the TimeSpan difference in an integer variable.
            // Add 1 to the total number of days to make up for the floor rounding.
            // This will insure that when the extra hours are cut out, they can be accounted for by rounding up.
            // The result is human readable and accurate as a result.
            int daysLeft = diff.Days + 1;
            // Display the number of days left until Christmas
            Console.WriteLine($"This means that there are {daysLeft} days left until Christmas!");
            // Pause console until user enters a keystroke.
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            // End of task three.
        }

        // This method will preform the fourth task.
        static void GlazerCalc()
        {
            // Define variables

            // Define numaric variables
            double width, height, woodLength, glassArea, glassAreaPerPane;

            // Define string variables
            string widthString, heightString;

            // Get user inputs

            // Prompt the user for the width
            Console.WriteLine("Please enter the Width in meters:");
            widthString = Console.ReadLine();

            // Prompt user for the height
            Console.WriteLine("Please enter the Height in meters (Will be converted to feet):");
            heightString = Console.ReadLine();

            // Preform calculations

            // Convert strings into doubles
            width = double.Parse(widthString);
            height = double.Parse(heightString);

            // Do the math
            woodLength = 2 * (width + height) * 3.25;
            glassAreaPerPane = (width * height);
            glassArea = 2 * (width * height);

            // Display the results to the user
            Console.WriteLine($"The length of the wood will be {woodLength} feet");
            Console.WriteLine($"You will need two window panes that are {glassAreaPerPane} square meters" +
                $" for a total of {glassArea} square meters.");

            // Pause console until user enters a keystroke.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            // End of task four.
        }
    }
}