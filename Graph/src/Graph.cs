namespace Graph;

/// <summary>
/// Represents a graph using an adjacency list.
/// </summary>
/// <typeparam name="T">The type of vertices in the graph.</typeparam>
public class Graph<T>
{
    private Dictionary<T, List<T>> adjacencyList;

    /// <summary>
    /// Initializes a new instance of the <see cref="Graph{T}"/> class.
    /// </summary>
    public Graph()
    {
        adjacencyList = new Dictionary<T, List<T>>();
    }

    /// <summary>
    /// Adds an edge between two vertices in an adjacency list representation.
    /// </summary>
    /// <param name="vertexAdjacentFrom">The vertex from which the edge originates.</param>
    /// <param name="vertexAdjacentTo">The vertex to which the edge leads.</param>
    public void AddAdjacency(T vertexAdjacentFrom, T vertexAdjacentTo)
    {
        // Add 'vertexAdjacentTo' to the adjacency list of 'vertexAdjacentFrom'.
        if (!adjacencyList.ContainsKey(vertexAdjacentFrom))
        {
            adjacencyList[vertexAdjacentFrom] = new List<T>();
        }

        if (!adjacencyList.ContainsKey(vertexAdjacentTo))
        {
            adjacencyList[vertexAdjacentTo] = new List<T>();
        }

        adjacencyList[vertexAdjacentFrom].Add(vertexAdjacentTo);
        adjacencyList[vertexAdjacentTo].Add(vertexAdjacentFrom); // For an undirected graph
    }

    /// <summary>
    /// Performs a depth-first search starting from the specified vertex.
    /// </summary>
    /// <param name="startVertex">The vertex to start the search from.</param>
    /// <param name="visited">An array indicating whether each vertex has been visited.</param>
    public void DepthFirstSearch(T startVertex, Dictionary<T, bool> visited)
    {
        // Mark the current vertex as visited.
        visited[startVertex] = true;
        Console.Write(startVertex + " ");

        foreach (T adjacentVertex in adjacencyList[startVertex])
        {
            if (!visited[adjacentVertex])
            {
                DepthFirstSearch(adjacentVertex, visited);
            }
        }
    }

    /// <summary>
    /// Performs a depth-first search starting from the specified vertex.
    /// </summary>
    /// <param name="startVertex">The vertex to start the search from.</param>
    public void DepthFirstSearch(T startVertex)
    {
        // Mark the current vertex as visited.
        Dictionary<T, bool> visited = new Dictionary<T, bool>();
        foreach (var vertex in adjacencyList.Keys)
        {
            visited[vertex] = false;
        }

        DepthFirstSearch(startVertex, visited);
    }

    /// <summary>
    /// Performs a breadth-first search (BFS) starting from the specified vertex.
    /// </summary>
    /// <param name="startVertex">The vertex to start the BFS from.</param>
    public void BreadthFirstSearch(T startVertex)
    {
        Queue<T> queue = new(); // Queue for BFS traversal
        HashSet<T> visited = new(); // Set to track visited vertices

        queue.Enqueue(startVertex); // Enqueue the start vertex
        visited.Add(startVertex); // Mark it as visited

        while (queue.Count > 0)
        {
            T current = queue.Dequeue(); // Dequeue the current vertex
            Console.Write(current + " "); // Process the vertex (e.g., print it)

            foreach (T adjacentVertex in adjacencyList[current])
            {
                if (!visited.Contains(adjacentVertex))
                {
                    queue.Enqueue(adjacentVertex); // Enqueue unvisited adjacent vertices
                    visited.Add(adjacentVertex); // Mark them as visited
                }
            }
        }
    }

    /// <summary>
    /// Retrieves the adjacency list representing the graph.
    /// </summary>
    /// <returns>A dictionary where each vertex is associated with a list of its adjacent vertices.</returns>
    public Dictionary<T, List<T>> GetAdjacencies()
    {
        return adjacencyList;
    }
}