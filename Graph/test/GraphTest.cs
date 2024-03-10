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
    public void AddAdjacency_ShouldAddEdgeBetweenVertices()
    {
        // Arrange
        Graph<string> graph = new();

        // Act
        graph.AddAdjacency("A", "B");
        graph.AddAdjacency("B", "C");

        // Assert
        Assert.Contains("B", graph.GetAdjacencies()["A"]);
        Assert.Contains("A", graph.GetAdjacencies()["B"]);
        Assert.Contains("C", graph.GetAdjacencies()["B"]);
        Assert.Contains("B", graph.GetAdjacencies()["C"]);
    }

    [Fact]
    public void AddAdjacency_ShouldHandleExistingVertices()
    {
        // Arrange
        Graph<int> graph = new();

        // Act
        graph.AddAdjacency(1, 2);
        graph.AddAdjacency(2, 3);
        graph.AddAdjacency(1, 3);

        // Assert
        Assert.Contains(2, graph.GetAdjacencies()[1]);
        Assert.Contains(1, graph.GetAdjacencies()[2]);
        Assert.Contains(3, graph.GetAdjacencies()[2]);
        Assert.Contains(2, graph.GetAdjacencies()[3]);
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
    public void DepthFirstSearch_ShouldProduceCorrectOutput()
    {
        // Arrange
        Graph<string> graph = new();
        graph.AddAdjacency("A", "B");
        graph.AddAdjacency("A", "C");
        graph.AddAdjacency("B", "D");
        graph.AddAdjacency("C", "E");
        graph.AddAdjacency("D", "E");
        graph.AddAdjacency("D", "F");

        // Act
        var result = CaptureConsoleOutput(() =>
        {
            Console.Write("DFS: ");
            graph.DepthFirstSearch("A");
        });
        var actual = result.Trim();

        // Assert
        string expected = "DFS: A B D E C F";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BreadthFirstSearch_ShouldProduceCorrectOutput()
    {
        // Arrange
        Graph<string> graph = new();
        graph.AddAdjacency("A", "B");
        graph.AddAdjacency("A", "C");
        graph.AddAdjacency("B", "D");
        graph.AddAdjacency("C", "E");
        graph.AddAdjacency("D", "E");
        graph.AddAdjacency("D", "F");

        // Act
        var result = CaptureConsoleOutput(() =>
        {
            Console.Write("BFS: ");
            graph.BreadthFirstSearch("A");
        });
        var actual = result.Trim();

        // Assert
        string expected = "BFS: A B C D E F";
        Assert.Equal(expected, actual);
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
        Assert.True(adjacencies.ContainsKey("A"));
        Assert.Contains("B", adjacencies["A"]);
        Assert.Contains("C", adjacencies["A"]);
        Assert.True(adjacencies.ContainsKey("B"));
        Assert.Contains("A", adjacencies["B"]);
        Assert.Contains("D", adjacencies["B"]);
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