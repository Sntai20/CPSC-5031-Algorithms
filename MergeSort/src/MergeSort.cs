namespace MergeSort;

public class MergeSort
{
    public static void Merge(int[] array, int left, int middle, int right)
    {
        // Find sizes of two subarrays to be merged.
        int lengthOfTempLeftArray = middle - left + 1;
        int lengthOfTempRightArray = right - middle;

        // Create temp arrays.
        int[] tempLeft = new int[lengthOfTempLeftArray];
        int[] tempRight = new int[lengthOfTempRightArray];

        // Copy a range of elements from the original array to the temporary arrays. This method is an O(n)
        // operation, where n is length. https://learn.microsoft.com/dotnet/api/system.array.copy?view=net-8.0
        Array.Copy(array, left, tempLeft, 0, lengthOfTempLeftArray);
        Array.Copy(array, middle + 1, tempRight, 0, lengthOfTempRightArray);

        // Initial indexes of first subarray, second subarray, and the merged array.
        int i = 0;
        int j = 0;
        int k = left;

        // Merge the subarrays. First subarray is array[left..middle]. Second subarray is array[middle+1..right].
        while (i < lengthOfTempLeftArray && j < lengthOfTempRightArray)
        {
            if (tempLeft[i] <= tempRight[j])
            {
                array[k] = tempLeft[i];
                i++;
            }
            else
            {
                array[k] = tempRight[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements of tempLeft[] if any.
        while (i < lengthOfTempLeftArray)
        {
            array[k] = tempLeft[i];
            i++;
            k++;
        }

        // Copy remaining elements of tempRight[] if any.
        while (j < lengthOfTempRightArray)
        {
            array[k] = tempRight[j];
            j++;
            k++;
        }
    }

    // Sort the array[left..right] using Merge().
    public static int[] Sort(int[] array, int left, int right)
    {
        if (left < right)
        {
            // Find the middle point.
            int middle = left + (right - left) / 2;

            // Sort first and second halves.
            Sort(array, left, middle);
            Sort(array, middle + 1, right);

            // Merge the sorted halves.
            Merge(array, left, middle, right);
        }

        return array;
    }

    // Helper method with input validation.
    public static int[] Sort(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The input array is sorted.");
            return array;
        }
        else if (array.Length < 1)
        {
            Console.WriteLine("The input array is empty.");
            return array;
        }
        else
        {
            return Sort(array, 0, array.Length - 1); ;
        }
    }
}