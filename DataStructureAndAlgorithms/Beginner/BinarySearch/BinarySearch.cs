namespace DataStructureAndAlgorithms.Beginner.BinarySearch;

public class BinarySearch
{
    public static void Main()
    {
        int[] arr = [1, 2, 3, 4, 5, 6];


        int res = BinarySearch(arr, 3);

        static int BinarySearch(int[] arr, int n)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (n == arr[mid]) return mid;

                if (n < arr[mid]) high = mid - 1;
                else low = mid + 1;
            }

            return -1;
        }
    }
}
