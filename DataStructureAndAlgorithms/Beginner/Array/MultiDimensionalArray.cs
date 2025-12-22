namespace DataStructureAndAlgorithms.Beginner.Array;

public class MultiDimensionalArray
{
    public static void Main()
    {
        int[,] array2DDeclaration = new int[2, 4];
        int[,,] array3DDeclaration = new int[2, 4, 6];
        int[,,,] array4DDeclaration = new int[2, 4, 6, 3];


        // Two dimensional array.

        int[,] array2DInitialization =
        {
            {1,2,3,4 },
            {5,6,7,8 }
        };

        // Three dimensional array.
        int[,,] array3DInitialiation =
        {
            {
                { 1,2,3,4,5,6}, {1,2,3,4,5,6 }, { 1,2,3,4,5,23}, { 1,2,3,4,5,6}
            },
            {
                { 1,2,3,4,5,6},{ 1,2,3,4,5,6},{1,2,3,4,5,6 },{1,2,3,45,5,6 },
            }
        };


        // Accessing array elements.

        Console.WriteLine(array2DInitialization[0, 0]);
        Console.WriteLine(array2DInitialization[0, 1]);
        Console.WriteLine(array2DInitialization[0, 2]);
        Console.WriteLine(array2DInitialization[0, 3]);
        Console.WriteLine(array2DInitialization[1, 0]);
        Console.WriteLine(array2DInitialization[1, 1]);
        Console.WriteLine(array2DInitialization[1, 2]);
        Console.WriteLine(array2DInitialization[1, 3]);



        Console.WriteLine(array3DInitialiation[0, 2, 5]);
        Console.WriteLine(array3DInitialiation[1, 3, 3]);



        // Getting the total count of elements or the length of given dimension.

        var allLength = array3DInitialiation.Length;
        var total = 1;

        for (int i = 0; i < 3; i++)
        {
            total *= array3DInitialiation.GetLength(i);
        }

        Console.WriteLine($"{allLength} equals {total}");




        int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

        foreach (var number in numbers2D)
        {
            Console.Write($"{number}");
        }

        int[,,] array3D = new int[,,]
        {
            { { 1, 2, 3 },

            { 4,   5,  6 }
            },

            { { 7, 8, 9 }, { 10, 11, 12 }
            }
        };


        foreach (var item in array3D)
        {
            Console.WriteLine(item);
        }


        int[,,] array3D1 = new int[,,]
        {
            {{1,2,3 },{4,5,6 } },
            { { 7,8,9},{10,11,12 } }
        };


        for(int i = 0; i < array3D1.GetLength(0); i++)
        {
            for(int j = 0; j < array3D1.GetLength(1); j++)
            {
                for(int k = 0; k < array3D1.GetLength(2); k++)
                {
                    Console.WriteLine(array3D1[i,j,k]);
                }
            }
        }






    }
}
