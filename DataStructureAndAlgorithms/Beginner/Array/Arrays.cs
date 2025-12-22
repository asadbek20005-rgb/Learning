namespace DataStructureAndAlgorithms.Beginner.Array;

public class Arrays
{
    int?[] array; // non-nullable array of nullable element types
    int[]? array2; // nullable array of non-nullable elements types
    int?[]? array3; // nullable array of nullable element types


    int[] numbers = new int[10]; // All values are 0
    string[] messages = new string[10]; // All values are null.

    // Using ? operator in string array and all works
    string?[] messages2;
    string[]? messages3;
    string?[]? messages4;


    // Declare a single-dimensional array of 5 integers.
    int[] array1 = new int[5];

    // Declare and set array element value.
    int[] array_second = [1, 2, 3, 4, 5, 6];

    // Declare two-dimensional array.
    int[,] multiDimensionalArray1 = new int[2, 3];

    // Declare and set array element value.
    int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

    // Declace a jagged array.
    public int[][] jaggedArray = new int[6][];

    // Set the values of the first array in the jagged array structure.
    
    void Main()
    {
        jaggedArray[0] = [1, 2, 3, 4, 4];
    }


    // Collection expression
    int[] array_collection = [1, 2, 3, 4, 5];

    // Alternative syntax
    int[] array_alternative = { 1, 2, 3, };

}
