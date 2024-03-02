/* Name: Antonio Santana
 * Problem: Implement HeapSort per the algorithm* to sort an array A in ascending order.
 * 
 * * Which algorithm? You pick. A big part of “algorithms” is knowing how to convert mathy pseudo-code into
 * your language of choice. So use the textbook, use the slides, use the Internet… just pick one and run with
 * it. However, do not just copy some code you found on the internet. (It’s pretty obvious when you do and
 * that will be counted as cheating.)
 * 
 * Here’s what you need to turn in:
 * 1. Where you got the algorithm from.
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
    public void Sort_WhenValuesAreUnsorted_SortsValues()
    {
        // Arrange
        int[] actual = { 12, 11, 13, 5, 6, 7 };
        int[] expected = { 5, 6, 7, 11, 12, 13 };

        // Act
        HeapSort.Sort(actual);

        // Assert
        Assert.Equal(expected, actual);
    }
}