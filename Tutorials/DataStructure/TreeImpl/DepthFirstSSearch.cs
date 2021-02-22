using System;
namespace DataStructure.TreeImpl
{
    public class DepthFirstSSearch
    {
        BinarySearchTreeImpl bst;

        public DepthFirstSSearch()
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

        public void DFS()
        {
            var rootNode = bst.Find(75);

            DFSRecursive(rootNode);
        }

        private void DFSRecursive(BSTNode node)
        {
            Console.WriteLine(node);

            if(node.LeftNode != null)
            {
                DFSRecursive(node.LeftNode);
            }
            if(node.RightNode != null)
            {
                DFSRecursive(node.RightNode);
            } 
        }
    }
}
