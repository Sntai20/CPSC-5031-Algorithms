/* Name: Antonio Santana
 * Problem: Here’s what I want you to do… for the graph above:
 *   1. Write a Depth-First Search function and output the results.
 *   2. Write a Breadth-First Search function and output the results.
 *
 * Then, for this graph:
 *   1. Write a Topological Sort function and display the results.
 *   The results should be the name of the algorithm, followed by a colon,
 *   followed by the node names separated by spaces.
 *   Example: DFS: A B C F H D E G
 *
 * Here’s what you need to turn in:
 *   1. Where you got the algorithms from
 *   2. Your code
 *   3. The output of your code
 *   4. An explanation of why you chose the test cases you did
 * FAQ
 *   1. How many test cases do I need? You decide. It’s your code, so you should best know
 *      where things might go wrong. Add test cases that explore each of these places where
 *      something could break.
 *   2. Can I get the algorithms off Wikipedia? Yes!
 *   3. This assignment seems bigger? Yes, which is why I made it worth more points.
 */
namespace GraphTest;

using Graph;

public class GraphTest
{
    [Fact]
    public void DepthFirstSearch_ShouldProduceCorrectOutput()
    {
        // Arrange
        Graph<string> graph = new();
        graph.AddAdjacency("A", "B");
        graph.AddAdjacency("A", "F");
        graph.AddAdjacency("A", "G");
        graph.AddAdjacency("B", "C");
        graph.AddAdjacency("B", "D");
        graph.AddAdjacency("C", "F");
        graph.AddAdjacency("F", "H");
        graph.AddAdjacency("D", "E");
        graph.AddAdjacency("E", "F");
        graph.AddAdjacency("G", "D");

        // Act
        var result = CaptureConsoleOutput(() =>
        {
            Console.Write("DFS: ");
            graph.DepthFirstSearch("A");
        });
        var actual = result.Trim();

        // Assert
        string expected = "DFS: A B C F H D E G";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BreadthFirstSearch_ShouldProduceCorrectOutput()
    {
        // Arrange
        Graph<string> graph = new();
        graph.AddAdjacency("A", "B");
        graph.AddAdjacency("A", "F");
        graph.AddAdjacency("A", "G");
        graph.AddAdjacency("B", "C");
        graph.AddAdjacency("B", "D");
        graph.AddAdjacency("C", "F");
        graph.AddAdjacency("F", "H");
        graph.AddAdjacency("D", "E");
        graph.AddAdjacency("E", "F");
        graph.AddAdjacency("G", "D");

        // Act
        var result = CaptureConsoleOutput(() =>
        {
            Console.Write("BFS: ");
            graph.BreadthFirstSearch("A");
        });
        var actual = result.Trim();

        // Assert
        string expected = "BFS: A B F G C D H E";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TopologicalSort_ShouldReturnCorrectOutput()
    {
        // Arrange
        Graph<string> graph = new();
        graph.AddAdjacency("Underwear", "Pants");
        graph.AddAdjacency("Pants", "Belt");
        graph.AddAdjacency("Underwear", "Shoes");
        graph.AddAdjacency("Pants", "Shoes");
        graph.AddAdjacency("Shirt", "Belt");
        graph.AddAdjacency("Shirt", "Tie");
        graph.AddAdjacency("Tie", "Jacket");
        graph.AddAdjacency("Socks", "Shoes");
        graph.AddAdjacency("Watch", string.Empty);

        // Act
        var result = CaptureConsoleOutput(() =>
        {
            List<string> sortedOrder = graph.TopologicalSort();
            Console.Write(string.Join(" ", sortedOrder));
        });

        // Assert
        string expectedOutput = "Underwear Shirt Socks Watch Pants Tie  Belt Shoes Jacket";
        Assert.Equal(expectedOutput, result.Trim());
    }

    [Fact]
    public void AddAdjacency_ShouldAddEdgeBetweenVertices()
    {
        // Arrange
        Graph<string> graph = new();

        // Act
        graph.AddAdjacency("A", "B");
        graph.AddAdjacency("B", "C");

        // Assert
        Assert.Contains("B", graph.GetAdjacencies()["A"]);
        Assert.Contains("C", graph.GetAdjacencies()["B"]);
    }

    [Fact]
    public void DepthFirstSearch_ShouldVisitAllConnectedVertices()
    {
        // Arrange
        Graph<int> graph = new();
        graph.AddAdjacency(1, 2);
        graph.AddAdjacency(1, 3);
        graph.AddAdjacency(2, 4);
        graph.AddAdjacency(3, 5);

        Dictionary<int, bool> visited = new();
        foreach (var vertex in graph.GetAdjacencies().Keys)
        {
            visited[vertex] = false;
        }

        // Act
        var result = CaptureConsoleOutput(() =>
        {
            graph.DepthFirstSearch(1, visited);
        });

        // Assert
        string expectedOutput = "1 2 4 3 5";
        Assert.Equal(expectedOutput, result.Trim());
    }

    [Fact]
    public void BreadthFirstSearch_ShouldVisitAllConnectedVertices()
    {
        // Arrange
        Graph<int> graph = new();
        graph.AddAdjacency(1, 2);
        graph.AddAdjacency(1, 3);
        graph.AddAdjacency(2, 4);
        graph.AddAdjacency(3, 5);

        // Act
        var result = CaptureConsoleOutput(() =>
        {
            graph.BreadthFirstSearch(1);
        });

        // Assert
        string expectedOutput = "1 2 3 4 5";
        Assert.Equal(expectedOutput, result.Trim());
    }

    [Fact]
    public void GetAdjacencies_ShouldReturnCorrectAdjacencyList()
    {
        // Arrange
        Graph<string> graph = new();
        graph.AddAdjacency("A", "B");
        graph.AddAdjacency("A", "C");
        graph.AddAdjacency("B", "D");

        // Act
        var adjacencies = graph.GetAdjacencies();

        // Assert
        Assert.True(adjacencies.ContainsKey("B"));
        Assert.True(adjacencies.ContainsKey("D"));
        Assert.Contains("B", adjacencies["A"]);
        Assert.Contains("C", adjacencies["A"]);
        Assert.Contains("D", adjacencies["B"]);
    }

    [Fact]
    public void TopologicalSort_ShouldHandleCyclicGraph()
    {
        // Arrange
        Graph<string> graph = new();
        graph.AddAdjacency("A", "B");
        graph.AddAdjacency("B", "C");
        graph.AddAdjacency("C", "A"); // Introduce a cycle

        // Act
        List<string> sortedOrder = graph.TopologicalSort();

        // Assert
        Assert.Empty(sortedOrder); // No valid topological order due to the cycle
    }

    // Helper method to capture console output.
    private string CaptureConsoleOutput(Action action)
    {
        using (var consoleOutput = new ConsoleOutput())
        {
            action();
            return consoleOutput.GetOutput();
        }
    }
}

// Helper class to capture console output.
public class ConsoleOutput : IDisposable
{
    private readonly StringWriter stringWriter;
    private readonly TextWriter originalOutput;

    public ConsoleOutput()
    {
        stringWriter = new StringWriter();
        originalOutput = Console.Out;
        Console.SetOut(stringWriter);
    }

    public string GetOutput()
    {
        return stringWriter.ToString();
    }

    public void Dispose()
    {
        Console.SetOut(originalOutput);
        stringWriter.Dispose();
    }
}