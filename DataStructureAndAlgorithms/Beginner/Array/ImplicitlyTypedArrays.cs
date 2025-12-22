namespace DataStructureAndAlgorithms.Beginner.Array;

public class ImplicitlyTypedArrays
{
    public static void Main()
    {
        int[] a = new int[] { 1, 10, 100, 1000 }; // int[]

        // Accessing array
        Console.WriteLine("First element: " + a[0]);
        Console.WriteLine("Second element: " + a[1]);
        Console.WriteLine("Third element: " + a[2]);
        Console.WriteLine("Fourth element: " + a[3]);


        var b = new[] { "helloo", null, "wordl"}; // string[]

        Console.WriteLine(string.Join(" ", b));

        // single dimension jagged array

        int[][] c = [
                [1,2,3,34,4],
                [2324,34543,654]

            ];

        // Looping through the outer array .

        //for(var i = 0; i < c.Length; i++)
        //{
        //    // Looping through each inner array
        //    for(int j = 0; j < c[i].Length; j++)
        //    {
        //        // Accessing each element and printing it to the console
        //        Console.WriteLine($"Element at c[{i}][{j}] is: {c[i][j]}");
        //    }
        //}


        // jagged array of strings

        string[][] d = [
                ["djsodifjds", "sajdksf"],
                ["sasad", "sknd"],

            ];


        // // Looping through the outer array
        int i = 0;
        foreach (var subArray in d)
        {
            // Looping through each inner array
            int j = 0;
            foreach (var element in subArray)
            {
                // Accessing each element and printing it to the console
                Console.WriteLine($"Element at d[{i}][{j}] is: {element}");
                j++;
            }
            i++;
        }
    }
}
