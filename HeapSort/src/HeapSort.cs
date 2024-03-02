namespace HeapSort;

/// <summary>
/// A Heap Sort implementation.
/// </summary>
public class HeapSort
{
    /// <summary>
    /// Sort an array in ascending order.
    /// </summary>
    /// <param name="array">The array which to sort.</param>
    public static void Sort(int[] array)
    {
        int arrayLength = array.Length;

        // Build heap (rearrange array).
        for (int i = arrayLength / 2 - 1; i >= 0; i--)
        {
            Heapify(array, arrayLength, i);
        }

        // One by one extract an element from heap.
        for (int i = arrayLength - 1; i > 0; i--)
        {
            // Move current root to end.
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            // Call max heapify on the reduced heap.
            Heapify(array, i, 0);
        }
    }

    /// <summary>
    /// To heapify a subtree rooted with node i which is an index in array[].
    /// </summary>
    /// <param name="array">The array which to sort.</param>
    /// <param name="arrayLength">The size of the heap.</param>
    /// <param name="i">The node root node.</param>
    public static void Heapify(int[] array, int arrayLength, int i)
    {
        int largest = i; // Initialize largest as root
        int left = 2 * i + 1; // left = 2*i + 1
        int right = 2 * i + 2; // right = 2*i + 2

        // If left child is larger than root.
        if (left < arrayLength && array[left] > array[largest])
        {
            largest = left;
        }

        // If right child is larger than largest so far.
        if (right < arrayLength && array[right] > array[largest])
        {
            largest = right;
        }

        // If largest is not root.
        if (largest != i)
        {
            int swap = array[i];
            array[i] = array[largest];
            array[largest] = swap;

            // Recursively heapify the affected sub-tree.
            Heapify(array, arrayLength, largest);
        }
    }
}