using System;
using DataStructure.LinkedListImpl;

namespace DataStructure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //PrintSinglyLinkedListOutput();
            //PrintDoublyLinkedListOutput();
            //PrintPostFixCalculation();
            //BST();
            //BFS();

            Graph_BFS();
            Graph_DFS();

        }

        private static void PrintSinglyLinkedListOutput()
        {
            var ll = new SinglyLinkedList<int>();
            ll.Add(1);
            ll.Add(4);
            ll.Add(5);

            Console.WriteLine(ll.Count);
            var isContain = ll.Contains(7);

            Console.WriteLine("Is Contain: " + isContain);

            foreach (int value in ll)
            {
                Console.Write(value);
            }

            Console.ReadKey();
        }

        private static void PrintDoublyLinkedListOutput()
        {
            var ll = new DoublyLinkedList<int>();
            ll.Add(3);
            ll.Add(7);
            ll.Add(9);
            ll.Add(12);

            Console.WriteLine(ll.Count);
            var isContain = ll.Contains(7);

            Console.WriteLine("Is Contain: " + isContain);

            foreach (int value in ll)
            {
                Console.Write(value);
            }

            Console.ReadKey();
        }

        
        public static void BST()
        {
            var bst = new TreeImpl.BinarySearchTreeImpl();

            bst.Insert(75);
            bst.Insert(57);
            bst.Insert(60);
            bst.Insert(32);
            bst.Insert(7);
            bst.Insert(44);
            bst.Insert(90);
            bst.Insert(86);
            bst.Insert(93);
            bst.Insert(99);

            //bst.InOrderTraversal();
            //bst.PreOrderTraversal();
            bst.PostOrderTraversal();
        }

        public static void BFS()
        {
            var bfs = new TreeImpl.BreadthFirstSearch();
            bfs.BFS();
        }

        public static void Graph_BFS()
        {
            var bfs = new Graph.Graph_BFS_DFS(4);
            bfs.PerformBFS();
        }

        public static void Graph_DFS()
        {
            var bfs = new Graph.Graph_BFS_DFS(4);
            bfs.PerformDFS();
        }
    }
}