namespace DataStructureAndAlgorithms.Beginner.SelectionSort;

public class Sort
{
    public static void Sort2(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            // Assume the current position holds
            // the minimum element

            int min_idx = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j]  < arr[min_idx])
                {
                    min_idx = j;

                }
            }


            // Move  minimum element to its
            // correct position

            int temp = arr[i];
            arr[i] = arr[min_idx];
            arr[min_idx] = temp;
        }
    }
}
