namespace DataStructureAndAlgorithms.Beginner.Array;

public class JaggedArrays
{
    public static void Main()
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = [1, 2, 3, 4, 5];
        jaggedArray[1] = [2, 3, 4, 5];
        jaggedArray[2] = [3, 4, 5];

        int[][] jaggedArray2 =
            [
                [1,2,3,4,5],
                [2,3,4,5],
                [3,4,5],
                [4,5]
            ];


        // Assign 77 to the second element ([1]) of the first array ([0])
        jaggedArray2[0][1] = 77;

        // Assign 88 to the second element ([1]) of the third array ([2])

        jaggedArray2[2][1] = 88;


        int[][,] jaggedArray3 =
            [
                new int[,] { {1,2,3 }, { 4,5,6} },
                new int[,] { {0,345,46,6 }, { 123,4,5,6} },
                new int[,] {{23,43,546,76,43}, { 12,435,457,43,21} }
            ];


        //Console.Write(jaggedArray3[0][1, 0]);

        //Console.WriteLine(jaggedArray3.Length);


        // Declare the array of two elements.

        int[][] arr = new int[2][];

        // Initialize the elements.

        arr[0] = [1, 2, 3, 4, 5, 5, 6];
        arr[1] = [5, 3, 4, 5, 6, 7, 8, 2];

        // Display the array elements.
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr[i].Length; j++)
            {
                Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
            }
        }
    }
}
