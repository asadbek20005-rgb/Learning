namespace DataStructureAndAlgorithms.Beginner.String;

public class ImmutablitiyOfStrings
{
    public static void Main()
    {
        string s1 = "A string is more";
        string s2 = "than the sum of its chars";

        // Concatenate s1 and s2. This actually creates a new
        // string object and stores it in s1, releasing the 
        // reference to the original object.
        s1 += s2;


        string str1 = "Hello";
        string str2 = str1;

        str1 += "World";
        Console.WriteLine(str2);
    }
}
