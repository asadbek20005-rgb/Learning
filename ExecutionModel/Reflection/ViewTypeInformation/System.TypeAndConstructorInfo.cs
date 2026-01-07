using System.Reflection;

namespace ExecutionModel.Reflection.ViewTypeInformation;

public class System
{
    public static void Main()
    {
        Type t = typeof(string);
        Console.WriteLine($"Listting all the public constructors of the {t} type");
        // Constructors
        ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine("//Constructors");    
        PrintMemebers(ci);
    }

    public static void PrintMemebers(MemberInfo[] members)
    {
        foreach (var memberInfo in members)
        {
            Console.WriteLine($"{"     "}{memberInfo}");
        }
        Console.WriteLine();
    }
}
