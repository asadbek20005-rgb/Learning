using System.Reflection;

namespace ExecutionModel.Reflection.ViewTypeInformation;

public class FileName
{
    public static void Main(string[] args)
    {
        // Gets the mscorlib assembly in which the object is defined
        Assembly a = typeof(object).Module.Assembly;



        // Loads an assembly using its file name.
        Assembly a2 = Assembly.LoadFrom("MyExe.exe");
        // Gets the type names from the assembly
        Type[] types = a2.GetTypes();
        foreach (Type t in types)
        {
            Console.WriteLine(t);
        }



    }
}
