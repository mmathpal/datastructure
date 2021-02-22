using System;
namespace DataStructure.TreeImpl
{
    public class BSTNode
    {
        public int Data { get; set; }
        public BSTNode LeftNode { get; set; }
        public BSTNode RightNode { get; set; }

        public BSTNode(int value)
        {
            Data = value;
        }

    }
}
