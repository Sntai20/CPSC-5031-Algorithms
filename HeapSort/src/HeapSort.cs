namespace HeapSort;

/// <summary>
/// A Heap Sort implementation.
/// </summary>
public class HeapSort
{
    /// <summary>
    /// Sorts the input integer array in ascending order using the heap sort algorithm.
    /// </summary>
    /// <param name="array">The array which to sort.</param>
    /// <returns>The sorted array.</returns>
    public static int[] Sort(int[] array)
    {
        int arrayLength = array.Length;

        // Build the initial max heap.
        for (int i = arrayLength / 2 - 1; i >= 0; i--)
        {
            Heapify(array, arrayLength, i);
        }

        // Extract elements from the heap one by one.
        for (int i = arrayLength - 1; i > 0; i--)
        {
            // Swap the root (max element) with the last element.
            Swap(array, 0, i);

            // Re-heapify the remaining elements.
            Heapify(array, i, 0);
        }

        return array;
    }

    /// <summary>
    /// To heapify a subtree rooted with node i which is an index in array[].
    /// </summary>
    /// <param name="array">The array which to sort.</param>
    /// <param name="arrayLength">The size of the heap.</param>
    /// <param name="i">The root node.</param>
    public static void Heapify(int[] array, int arrayLength, int i)
    {
        // Initialize largest as root.
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        // Find the largest among root, left child, and right child.
        if (left < arrayLength && array[left] > array[largest])
        {
            largest = left;
        }

        // If right child is larger than largest so far.
        if (right < arrayLength && array[right] > array[largest])
        {
            largest = right;
        }

        // If largest is not root, swap and re-heapify.
        if (largest != i)
        {
            Swap(array, i, largest);
            Heapify(array, arrayLength, largest);
        }
    }

    /// <summary>
    /// Swaps the elements at positions i and j in the given array.
    /// </summary>
    /// <param name="array">The input array.</param>
    /// <param name="i">The index of the first element to swap.</param>
    /// <param name="j">The index of the second element to swap.</param>
    public static void Swap(int[] array, int i, int j)
    {
        (array[j], array[i]) = (array[i], array[j]);
    }
}