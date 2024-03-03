// Driver code.
int[] array = { 5, 2, 9, 1, 5, 6, 3 };
int[] sortedArray = HeapSort.HeapSort.Sort(array);

Console.WriteLine("Sorted array is");
for (int i = 0; i < sortedArray.Length; ++i)
{
    Console.Write(sortedArray[i] + " ");
}