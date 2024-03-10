using Graph;

Graph<string> graph = new();

graph.AddAdjacency("A", "B");
graph.AddAdjacency("A", "C");
graph.AddAdjacency("B", "D");
graph.AddAdjacency("C", "E");
graph.AddAdjacency("D", "E");
graph.AddAdjacency("D", "F");

Console.Write("DFS: ");
graph.DepthFirstSearch("A");

Console.Write("\nBFS: ");
graph.BreadthFirstSearch("A");