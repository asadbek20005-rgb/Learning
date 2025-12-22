namespace DataStructureAndAlgorithms.Beginner.Array;

public class PassMultidimensionalArraysAsArguments
{
    public static void Main()
    {
        Print2DArray(new int[,]
        {
            {1, 2 },
            {3, 4 },
            {5, 6 },
            {6, 7},
            {7, 8}
        }

        );
    }

    static void Print2DArray(int[,] arr)
    {
        // Display the array elements.

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine(arr[i, j]);
            }
        }
    }
}
