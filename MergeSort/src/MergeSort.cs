namespace MergeSort;

public class MergeSort
{
    // Merges two subarrays of []array. First subarray is array[l..m] Second subarray is array[m+1..r].
    public static void Merge(int[] array, int left, int middle, int right)
    {
        // Find sizes of two subarrays to be merged.
        int n1 = middle - left + 1;
        int n2 = right - middle;

        // Create temp arrays.
        int[] tempLeft = new int[n1];
        int[] tempRight = new int[n2];
        int i, j;

        // Copy data to temp arrays.
        for (i = 0; i < n1; ++i)
        {
            tempLeft[i] = array[left + i];
        }
        for (j = 0; j < n2; ++j)
        {
            tempRight[j] = array[middle + 1 + j];
        }

        // Initial indexes of first and second subarrays.
        i = 0;
        j = 0;

        // Initial index of merged subarray array.
        int k = left;
        while (i < n1 && j < n2)
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

        // Copy remaining elements of L[] if any.
        while (i < n1)
        {
            array[k] = tempLeft[i];
            i++;
            k++;
        }

        // Copy remaining elements of R[] if any.
        while (j < n2)
        {
            array[k] = tempRight[j];
            j++;
            k++;
        }
    }

    // Sort the array[l..r] using merge()
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

    public static void printArray(int[] array)
    {
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}