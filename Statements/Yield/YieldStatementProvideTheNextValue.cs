namespace Statements.Yield;

public static class YieldStatementProvideTheNextValue
{
    public static async Task Main()
    {


        foreach (var item in ProduceEvenNumbers(10))
        {
            Console.WriteLine(item);
        }


        IEnumerable<int> ProduceEvenNumbers(int upto)
        {
            for (int i = 0; i <= upto; i += 2)
            {
                yield return i;
            }
        }

        Console.WriteLine(string.Join(" ", TakeWhilePositive([1, 2, 3, 4, 5, 0, -2, -4])));

        IEnumerable<int> TakeWhilePositive(IEnumerable<int> numbers)
        {
            foreach (var item in numbers)
            {
                if (item > 0)
                {
                    yield return item;
                }
                else
                {
                    yield break;
                }
            }
        }



        await foreach (var item in GenerateNumbersAsync(5))
        {
            Console.WriteLine(item);
            Console.Write(" ");
        }

        async IAsyncEnumerable<int> GenerateNumbersAsync(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return await ProduceNumberAsync(count);
            }
        }

        async Task<int> ProduceNumberAsync(int seed)
        {
            await Task.Delay(1000);
            return 2 * seed;
        }


        Example();

        static void Example()
        {
            var point = new Point(1,2,3);
            foreach(var item in point)
            {
                Console.Write(item);
            }

        }


    }

    public readonly record struct Point(int X, int Y, int Z)
    {
        public IEnumerator<int> GetEnumerator()
        {
            yield return X; yield return Y; yield return Z;
        }
    }
}
