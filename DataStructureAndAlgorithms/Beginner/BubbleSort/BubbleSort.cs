namespace DataStructureAndAlgorithms.Beginner.BubbleSort;

public class BubbleSort
{
    public static void Main()
    {

        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Sort(arr);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        static void Sort(int[] arr)
        {
            int i, j, temp;

            bool swaped;

            for (i = 0; i < arr.Length - 1; i++)
            {
                swaped = false;

                for (j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swaped = true;
                    }
                }
                if (!swaped) break;
            }
        }
    }
}
