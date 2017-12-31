using System.Collections.Generic;

namespace HackerRankCode
{
    class Graph
    {
        private int V;    // No. of vertices

        // Pointer to an array containing adjacency lists
        private List<int>[] adj;

        int[] countAr;
        int count;

        // Constructor
        public Graph(int v)
        {
            V = v;
            countAr = new int[v];
            adj = new List<int>[V];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        // function to add an edge to graph
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v’s list.
            adj[w].Add(v);
        }

        // A recursive function used by DFS
        private void DFSUtil(int v, bool[] visited)
        {
            // Mark the current node as visited and print it
            visited[v] = true;
            count++;

            // Recur for all the vertices adjacent to this vertex
            foreach (int i in adj[v])
            {
                if (!visited[i])
                    DFSUtil(i, visited);
            }

        }

        // DFS traversal of the vertices reachable from v
        public int[] DFS()
        {
            // Mark all the vertices as not visited
            bool[] visited = new bool[V];
            for (int i = 0; i < V; i++)
                visited[i] = false;

            int x = 0;
            // Call the recursive helper function to print DFS traversal
            for (int i = 0; i < V; i++)
            {
                if (!visited[i])
                {
                    count = 0;
                    DFSUtil(i, visited);
                    countAr[x] = count;
                    x++;
                }
            }
            return countAr;
        }
    }
}
