using System;
using System.Collections.Generic;



namespace DataStructure.Graph
{
    public class Graph_BFS_DFS
    {
        //Number of vertices
        private int _V;

        //Adjacent lists
        List<int>[] _adj;

        public Graph_BFS_DFS(int V)
        {
            _adj = new List<int>[V];
            for(int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new List<int>();
            }

            _V = V;
        }

        //method to add an edge into the graph
        private void AddEdge(int v, int w)
        {
            _adj[v].Add(w);
        }

        //prints BFS traversal from a given source s
        private void BFS(int v)
        {
            //mark all vertices as not visited by default
            bool[] visited = new bool[_V];
            for(int i = 0; i < _V; i++)
            {
                visited[i] = false;
            }

            //create a queue for BFS
            Queue<int> queue = new Queue<int>();

            visited[v] = true;
            queue.Enqueue(v);

            while(queue.Count > 0)
            {
                //dequeue a vertex from queue and print it
                v = queue.Dequeue();

                Console.WriteLine(v);

                //Get all adjacent vertices of the dequeue vertex s.
                //If an adjacent has not been visited then mark it visited and enqueue it
                List<int> list = _adj[v];

                foreach(var val in list)
                {
                    if (!visited[val]){
                        visited[val] = true;
                        queue.Enqueue(val);
                    }
                }
               
            }
        }

        public void PerformBFS()
        {
            AddEdge(0, 1);
            AddEdge(0, 2);
            AddEdge(1, 2);
            AddEdge(2, 0);
            AddEdge(2, 3);
            AddEdge(3, 3);


            Console.WriteLine("Following is the breadth first traverse starting from vertex 2: ");
            BFS(2);
        }


        private void DFS(int v)
        {
            //Marl all vertices as not visited by default
            bool[] visited = new bool[_V];

            //Call the recursive helper function
            DFSUtil(v, visited);
        }

        private void DFSUtil(int v, bool[] visited)
        {
            //mark all the current node as visited and print it
            visited[v] = true;
            Console.WriteLine(v);

            //Recur for all the vertices adjacent to this vertex
            List<int> vList = _adj[v];
            foreach(var n in vList)
            {
                if (!visited[n])
                {
                    DFSUtil(n, visited);
                }
            }

        }

        public void PerformDFS()
        {
            AddEdge(0, 1);
            AddEdge(0, 2);
            AddEdge(1, 2);
            AddEdge(2, 0);
            AddEdge(2, 3);
            AddEdge(3, 3);


            Console.WriteLine("Following is the depth first traverse starting from vertex 2: ");
            DFS(2);
        }
    }
}
