using System;

class Program
{
    static void Main()
    {
        // Declare an array to store 6 integers
        int[] numbers = new int[6] { 2, 3, 7, 2, 7, 5 }; // Initialize with the provided values

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

        // Display the numbers in the array, the largest number, and its occurrence count
        Console.WriteLine("The array is " + string.Join(" ", numbers));
        Console.WriteLine("The largest number is " + maxNumber);
        Console.WriteLine("The occurrence count of the largest number is " + occurrenceCount);
    }
}
