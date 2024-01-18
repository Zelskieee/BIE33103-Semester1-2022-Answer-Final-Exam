using System;

class Program
{
    static void Main()
    {
        // Declare an array to store 6 integers
        int[] numbers = new int[6];

        Console.WriteLine("Enter 6 integer numbers:");

        // Use a for loop to read 6 integers from the user and store them in the array
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Enter number {i + 1}: ");

            // Read the user input, convert it to an integer, and store it in the array
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                numbers[i] = userInput;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                // Decrement the loop counter to re-enter the current index
                i--;
            }
        }

        // Find the largest number in the array and count its occurrences
        int maxNumber = numbers[0];
        int occurrenceCount = 1; // at least one occurrence for the first element

        for (int i = 1; i < 6; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
                occurrenceCount = 1; // reset occurrence count for the new maxNumber
            }
            else if (numbers[i] == maxNumber)
            {
                occurrenceCount++; // increment occurrence count for each occurrence
            }
        }

        // Display the entered numbers, the largest number, and its occurrence count
        Console.WriteLine("\nEntered numbers:");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Number {i + 1}: {numbers[i]}");
        }

        Console.WriteLine($"\nLargest entered number: {maxNumber}");
        Console.WriteLine($"Occurrences of the largest number: {occurrenceCount}");
    }
}
