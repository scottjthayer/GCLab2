using System;

namespace Lab2RoomCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts input from user regarding length and width
            //displays area and perimeter
            //displays how much paint and carpet is needed
            //continue?
            
            Console.WriteLine("Hello! Welcome to the room calculator.");

            bool runAgain = true;
            while (runAgain)
            {
                

                Console.WriteLine("\nWhat is the length of the room?");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the width of the room?");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the height of the room?");
                double height = double.Parse(Console.ReadLine());

                double area = length * width;
                double volume = length * width * height;
                double perimeter = (2 * length) + (2 * width);
                Console.WriteLine($"The area is {area}sq ft. The perimeter is {perimeter}ft. The volume of the room is {volume} ft cubed.");

                double paint = perimeter / 5;
                double carpet = area / 5;
                Console.WriteLine($"You will need {paint} cans of paint. You will need {carpet} carpet tiles.\n");

                Console.WriteLine("Would you like to calculate for another room? (y/n)");
                string again = Console.ReadLine().ToLower();

                if (again == "y")
                {
                    runAgain = true;
                }
                else 
                { 
                    runAgain = false; 
                }
            }
            Console.Write("Thank you for using the room calculator. Hit any key to exit.\n");


        }
    }
}
