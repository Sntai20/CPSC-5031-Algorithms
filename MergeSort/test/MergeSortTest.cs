/* Name: Antonio Santana
 * Problem: Implement MergeSort algorithm shown in class and in the textbook to sort an array A in ascending order.
 * MergeSort’s time complexity is O(n log n), where n is the input size.
 *
 * Here are the test cases you should include:
 * Test Case #  Array
 *     1        []
 *     2        [ 0, 1, 2, 3 ]
 *     3        [ 0, 1, 2, 3, 4 ]
 *     4        [ 3, 1, 4, 1, 5, 9, 2, 6, 5 ]
 *     5        [ 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 ]
 * 
 * Part 2: Test cases
 * Having good test cases is very important when writing code. Good test cases not only test the “happy path” of your
 * code, but also test the boundary conditions where things can get strange. Of the 5 test cases shown above, only #5
 * specifically tests the “happy path”. The rest test boundaries.
 * 
 * Answer these questions in your homework submission:
 * 1. Why is test case #1 important?
 *    Test case one, tests whether the sorting method correctly handles an empty input array. In a recursive MergeSort
 *    implementation, a base case is crucial. When the input array is an empty array, the same empty array is expected
 *    as the result, and asserts equality. 
 * 2. What’s the key difference between test cases #2 and #3? Why is this important when testing MergeSort?
 *    Test case two, tests whether the sorting method preserves an already sorted array. Test case three is similar,
 *    but with a larger sorted array. It arranges a sorted array with five elements, expects the same sorted array as
 *    the result, and asserts equality. It is essential to verify this scenario because it validates the stability of
 *    the sorting algorithm. A stable sort algorithm preserves the relative order of equal elements. If the algorithm
 *    accidentally swaps equal elements, it would violate stability. If it fails to maintain order, it could lead to
 *    incorrect results in real-world scenarios.
 * 3. Test case #4 is some digits of π. What else is important about test case #4?
 *    Tests whether the sorting method correctly sorts an unsorted array. It arranges an unsorted array, expects the
 *    sorted array as the result, and asserts equality. The presence of duplicate elements, MergeSort must handle
 *    duplicates correctly and maintain their relative order. MergeSort is a stable sorting algorithm, which means
 *    that equal elements retain their original order after sorting.
 */
namespace MergeSortTest;

using MergeSort;

public class MergeSortTest
{
    [Fact]
    public void Sort_WhenInputEmptyArray_ReturnEmptyArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int[] expected = Array.Empty<int>();

        // Act
        int[] actual = MergeSort.Sort(emptyArray);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Sort_WhenInputIsSortedArray_ReturnSortedArray()
    {
        // Arrange
        int[] sortedArray = { 0, 1, 2, 3 };
        int[] expected = { 0, 1, 2, 3 };

        // Act
        int[] actual = MergeSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Sort_WhenInputIsSortedArrayWithFiveElements_ReturnSortedArray()
    {
        // Arrange
        int[] sortedArray = { 0, 1, 2, 3, 4 };
        int[] expected = { 0, 1, 2, 3, 4 };

        // Act
        int[] actual = MergeSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Sort_WhenInputIsUnsortedArray_ReturnSortedArray()
    {
        // Arrange
        int[] sortedArray = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
        int[] expected = { 1, 1, 2, 3, 4, 5, 5, 6, 9 };

        // Act
        int[] actual = MergeSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Sort_WhenInputIsSortedArrayInDecendingOrder_ReturnSortedArrayAscendingOrder()
    {
        // Arrange
        int[] sortedArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        int[] actual = MergeSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Merge_WhenValidInput_MergesSubarraysCorrectly()
    {
        // Arrange
        int[] actual = { 2, 5, 9, 1, 5, 6 };
        int left = 0;
        int middle = 2;
        int right = 5;
        int[] expected = { 1, 2, 5, 5, 6, 9 };

        // Act
        MergeSort.Merge(actual, left, middle, right);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Sort_WhenValidInput_SortsArrayCorrectly()
    {
        // Arrange
        int[] unsortedArray = { 5, 2, 9, 1, 5, 6 };
        int[] expected = { 1, 2, 5, 5, 6, 9 };

        // Act
        int[] actual = MergeSort.Sort(unsortedArray, 0, unsortedArray.Length - 1);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Sort_WhenInputSortedArray_ReturnSortedArray()
    {
        // Arrange
        int[] sortedArray = { 12 };
        int[] expected = { 12 };

        // Act
        int[] actual = MergeSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expected, actual);
        Assert.Single(actual);
    }

    [Fact]
    public void Sort_WhenInputUnsortedArray_ReturnSortedArray()
    {
        // Arrange
        int[] unsortedArray = { 12, 11, 13, 5, 6, 7 };
        int[] expected = { 5, 6, 7, 11, 12, 13 };

        // Act
        int[] actual = MergeSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expected, actual);
    }
}