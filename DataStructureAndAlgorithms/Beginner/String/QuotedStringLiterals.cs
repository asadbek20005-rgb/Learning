namespace DataStructureAndAlgorithms.Beginner.String;

public class QuotedStringLiterals
{
    public static void Main()
    {
        string columns = "Column 1 \tColumn 2 \t Column 3";
        // Output: Column 1    Column 2    Column 3

        Console.WriteLine(columns);
        string rows = "Row 1\r\nRow 2\r\nRow 3";
        /* Output:
          Row 1
          Row 2
          Row 3
        */

        Console.WriteLine(rows);


        string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge ";
        // Output: "The Æolean Harp", by Samuel Taylor Coleridge


        Console.WriteLine(title);
    }
}
