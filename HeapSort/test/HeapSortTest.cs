/* Name: Antonio Santana
 * Problem: Implement HeapSort per the algorithm* to sort an array A in ascending order.
 * 
 * * Which algorithm? You pick. A big part of “algorithms” is knowing how to convert mathy pseudo-code into
 * your language of choice. So use the textbook, use the slides, use the Internet… just pick one and run with
 * it. However, do not just copy some code you found on the internet. (It’s pretty obvious when you do and
 * that will be counted as cheating.)
 * 
 * Here’s what you need to turn in:
 * 1. Where you got the algorithm from. The class book Algorithms 4th Edition by Robert Sedgewick and Kevin Wayne https://algs4.cs.princeton.edu/24pq/Heap.java.html
 * 2. A screenshot of the algorithm if you got it from the internet.
 * 3. Your code, including test cases.
 * 4. The output of your code.
 * 5. An explanation of why you chose the test cases you did.
 * 
 * FAQ
 * 1. How many test cases do I need? You decide. It’s your code, so you should best know where things might
 *    go wrong. Add test cases that explore each of these places where something could break.
 * 2. Can I get the algorithm off Wikipedia? Yes. It just has to implement HeapSort.
 * 3. Are HeapSort and insertion into a Heap the same thing? NO. They are most definitely not the same thing!
 *    Make sure you’re doing HeapSort!
 * 4. Why are you making us write so much code that you said will just be in a library anyway? Because the
 *    best way to get better at coding is to write more code. That’s why I say “Let’s write more code!” in every
 *    homework and on the tests. Keep doing it and you will get just a little bit better every time.
 */
namespace HeapSortTest;

using HeapSort;

public class HeapSortTest
{
    [Fact]
    public void Sort_WhenValuesAreUnsorted_ReturnSortedArray()
    {
        // Arrange
        int[] unsortedArray = { 12, 11, 13, 5, 6, 7 };
        int[] expected = { 5, 6, 7, 11, 12, 13 };

        // Act
        int[] actual = HeapSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Sort_WhenEmptyArray_ReturnEmptyArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        var actual = HeapSort.Sort(emptyArray);

        // Assert
        Assert.Empty(actual);
    }

    [Fact]
    public void Sort_WhenSingleElementArray()
    {
        // Arrange
        int[] singleElementArray = { 42 };
        int expected = 42;

        // Act
        var actual = HeapSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expected, actual[0]);
    }

    [Fact]
    public void Sort_WhenRandomArray()
    {
        // Arrange
        int[] unsortedArray = { 5, 2, 9, 1, 5, 6, 3 };
        int[] expected = { 1, 2, 3, 5, 5, 6, 9 };

        // Act
        var actual = HeapSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Heapify_WhenLargestIsRoot()
    {
        // Arrange
        int[] actual = { 5, 10, 15 };
        int arrayLength = actual.Length;
        int i = 0;
        int[] expected = { 15, 10, 5 };

        // Act
        HeapSort.Heapify(actual, arrayLength, i);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Heapify_WhenLargestIsLeftChild()
    {
        // Arrange
        int[] actual = { 10, 5, 15 };
        int arrayLength = actual.Length;
        int i = 0;
        int[] expected = { 15, 5, 10 };

        // Act
        HeapSort.Heapify(actual, arrayLength, i);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Swap_ElementsSwapped()
    {
        // Arrange
        int[] array = { 1, 2, 3 };
        int i = 0;
        int j = 2;
        int expectedFirst = 3;
        int expectedSecond = 1;

        // Act
        HeapSort.Swap(array, i, j);

        // Assert
        Assert.Equal(expectedFirst, array[i]);
        Assert.Equal(expectedSecond, array[j]);
    }

    [Fact]
    public void Swap_SameIndex_NoChange()
    {
        // Arrange
        int[] array = { 10, 20, 30 };
        int i = 1;
        int j = 1;
        int expected = 20;

        // Act
        HeapSort.Swap(array, i, j);

        // Assert
        Assert.Equal(expected, array[i]);
        Assert.Equal(expected, array[j]);
    }
}