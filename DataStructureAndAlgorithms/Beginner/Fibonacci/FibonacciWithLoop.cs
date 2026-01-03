namespace DataStructureAndAlgorithms.Beginner.Fibonacci;

public class FibonacciWithLoop(int n1, int a1, int b1)
{
    private int n = n1;
    private int a = a1, b = b1;


    public void FindFibonacci()
    {
        for(int i = 3;  i<= n; i++)
        {
            int c = a + b;
            Console.Write(c + "");
            a = b;
            b = c;
        }
    }
}
