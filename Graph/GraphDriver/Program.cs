using Graph;

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

Console.Write("DFS: ");
graph.DepthFirstSearch("A");

Console.Write("\nBFS: ");
graph.BreadthFirstSearch("A");

Graph<string> topologicalSortGraph = new();
topologicalSortGraph.AddAdjacency("Underwear", "Pants");
topologicalSortGraph.AddAdjacency("Pants", "Belt");
topologicalSortGraph.AddAdjacency("Underwear", "Shoes");
topologicalSortGraph.AddAdjacency("Pants", "Shoes");
topologicalSortGraph.AddAdjacency("Shirt", "Belt");
topologicalSortGraph.AddAdjacency("Shirt", "Tie");
topologicalSortGraph.AddAdjacency("Tie", "Jacket");
topologicalSortGraph.AddAdjacency("Socks", "Shoes");
topologicalSortGraph.AddAdjacency("Watch", string.Empty);
List<string> sortedOrder = topologicalSortGraph.TopologicalSort();
Console.Write("\nTopological Sort Order: ");
Console.Write(string.Join(" ", sortedOrder));