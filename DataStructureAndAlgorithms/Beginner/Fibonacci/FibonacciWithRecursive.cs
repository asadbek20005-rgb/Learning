namespace DataStructureAndAlgorithms.Beginner.Fibonacci;

public class FibonacciWithRecursive
{
    public int FindFibonacci(int n)
    {
        if (n <= 2) return n;


        return FindFibonacci(n - 1) + FindFibonacci(n - 2);
    }
}
