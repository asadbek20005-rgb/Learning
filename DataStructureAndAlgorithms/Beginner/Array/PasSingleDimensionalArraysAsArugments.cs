namespace DataStructureAndAlgorithms.Beginner.Array;
using System;
public class PasSingleDimensionalArraysAsArugments
{
    static void DisplayArray(string[] array) => Console.WriteLine(string.Join(" ", array));
    // Change the array elements by reversing  
    static void ChangeArary(string[] array) => Array.Reverse(array);

    static void ChangeArrayElements(string[] array)
    {
        // Change the first 3 elements of array
        array[0] = "Mon";
        array[1] = "Tue";
        array[2] = "Fir";

    }

    public static void Main()
    {
        // Declare and initialize array
        string[] array = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

        // Display the array elements
        DisplayArray(array);
        Console.WriteLine();


        // Reverse the array
        ChangeArary(array);
        // Display the array again to verify that it stays reversed
        Console.WriteLine("Array weekDays after the call to ChangeArray: ");
        DisplayArray(array);
        Console.WriteLine();

        // Assign new values to individual array elements
        ChangeArrayElements(array);
        Console.WriteLine("Array elements after the call to ChangeArrayElements: ");
        DisplayArray(array);
        Console.WriteLine();



    }
}
