namespace MergeSort;

/// <summary>
/// An implementation of the merge sort algorithm.
/// </summary>
public class MergeSort
{
    /// <summary>
    /// Merges two subarrays within the given array. It calculates the sizes of the left and right subarrays, creates
    /// temporary arrays, and then merges the elements back into the original array.
    /// </summary>
    /// <param name="array">The original array.</param>
    /// <param name="left">The left index of the current subarray.</param>
    /// <param name="middle">The middle of the original array.</param>
    /// <param name="right">The right index of the current subarray.</param>
    public static void Merge(int[] array, int left, int middle, int right)
    {
        // Find sizes of two subarrays to be merged.
        int lengthOfTempLeftArray = middle - left + 1;
        int lengthOfTempRightArray = right - middle;

        // Create temporary arrays and copy a range of elements from the original array to the temporary arrays. This
        // method is an O(n) operation, where n is length. https://learn.microsoft.com/dotnet/csharp/tutorials/ranges-indexes
        int[] tempLeft = array[left..(left + lengthOfTempLeftArray)];
        int[] tempRight = array[(middle + 1)..(middle + 1 + lengthOfTempRightArray)];

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

    /// <summary>
    /// Sort the array[left..right] using Merge().
    /// </summary>
    /// <param name="array">The input array which to sort.</param>
    /// <param name="left">The left index of the current subarray.</param>
    /// <param name="right">The right index of the current subarray.</param>
    /// <returns>A sorted array.</returns>
    public static int[] Sort(int[] array, int left, int right)
    {
        if (left >= right)
        {
            return array;
        }

        // Find the middle point.
        int middle = left + (right - left) / 2;

        // Sort first and second halves.
        Sort(array, left, middle);
        Sort(array, middle + 1, right);

        // Merge the sorted halves.
        Merge(array, left, middle, right);

        return array;
    }

    /// <summary>
    /// Helper method with input validation serves as the entry point for sorting.
    /// </summary>
    /// <param name="array">The input array which to sort.</param>
    /// <returns>A sorted array.</returns>
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