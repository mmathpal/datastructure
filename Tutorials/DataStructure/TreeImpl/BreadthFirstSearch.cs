using System;
using System.Collections.Generic;
namespace DataStructure.TreeImpl
{
    public class BreadthFirstSearch
    {
        BinarySearchTreeImpl bst;

        public BreadthFirstSearch()
        {
            bst = new BinarySearchTreeImpl();

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
        }

        public void BFS()
        {
            var rootNode = bst.Find(75);
            Queue<BSTNode> queue = new Queue<BSTNode>();

            queue.Enqueue(rootNode);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                Console.WriteLine(node.Data);

                if (node.LeftNode != null)
                {
                    queue.Enqueue(node.LeftNode);
                }
                if (node.RightNode != null)
                {
                    queue.Enqueue(node.RightNode);
                }

            }          

        }
    }
}
