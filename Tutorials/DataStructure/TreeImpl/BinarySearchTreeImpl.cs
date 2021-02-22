using System;
namespace DataStructure.TreeImpl
{
    public class BinarySearchTreeImpl
    {
        BSTNode root;
        public BinarySearchTreeImpl()
        {
            //create an empty tree 
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Insert(int item)
        {
            BSTNode newNode = new BSTNode(item);

            if(root == null)
            {
                root = newNode;
                return;
            }
            else
            {
                InsertRecursive(root, item, root);
            }

        }

        private void InsertRecursive(BSTNode currentNode, int item, BSTNode previousNode, bool addToLeft = true)
        {
            if (currentNode == null)
            {
                BSTNode newNode = new BSTNode(item);
                if (addToLeft) {
                    previousNode.LeftNode = newNode;
                }
                else
                {
                    previousNode.RightNode = newNode;
                }

            }
            else if(item <= currentNode.Data)
            {
                previousNode = currentNode;
                InsertRecursive(currentNode.LeftNode, item, previousNode, true);
            }
            else
            {
                previousNode = currentNode;
                InsertRecursive(currentNode.RightNode, item, previousNode, false);
            }
           
        }

        public BSTNode Find(int item)
        {
            if(root == null)
            {
                throw new InvalidOperationException("Tree is empty");
            }

            BSTNode node = FindRecursive(root, item);
            if(node == null)
            {
                throw new Exception("Item not found");
            }
            else
            {
                return node;
            }
        }

        private BSTNode FindRecursive(BSTNode node, int item)
        {
            if(node.Data == item)
            {
                return node;
            }
            else if(item < node.Data)
            {
                FindRecursive(node.LeftNode, item);
            }
            else if(item > node.Data)
            {
                FindRecursive(node.RightNode, item);
            }
            
            return null;            
        } 

        public void Remove(int item)
        {
            BSTNode currentNode = root;
            BSTNode parentNode = root;

            bool isLeftChild = true;

            while (true)
            {

                if(item == currentNode.Data)
                {
                    break;
                }
                else if(item < currentNode.Data)
                {
                    isLeftChild = true;
                    parentNode = currentNode;
                    currentNode = currentNode.LeftNode;
                }
                else if(item < currentNode.Data)
                {
                    isLeftChild = false;
                    parentNode = currentNode;
                    currentNode = currentNode.RightNode;
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            //node to remove is a leaf node
            if(currentNode.LeftNode == null && currentNode.RightNode == null)
            {
                if (isLeftChild)
                {
                    parentNode.LeftNode = null;
                }
                else
                {
                    parentNode.RightNode = null;
                }
            }

            //not to remove has a left child
            else if(currentNode.LeftNode != null && currentNode.RightNode == null)
            {
                if(isLeftChild)
                {
                    parentNode.LeftNode = currentNode.LeftNode;
                }
                else
                {
                    parentNode.RightNode = currentNode.LeftNode;
                }                
            }

            //node to remove has a right child
            else if(currentNode.LeftNode == null && currentNode.RightNode != null)
            {
                if (isLeftChild)
                {
                    parentNode.RightNode = currentNode.RightNode;
                }
                else
                {
                    parentNode.LeftNode = currentNode.RightNode;
                }
            }
            //node to remove have both left and right child
            else
            {
                BSTNode successor = GetSuccessor(currentNode);
                if (isLeftChild)
                {
                    parentNode.LeftNode = successor;
                }
                else
                {
                    parentNode.RightNode = successor;
                }
            }
        }

        private BSTNode GetSuccessor(BSTNode node)
        {
            BSTNode parentOfSuccessor = node;
            BSTNode successor = node;
            BSTNode current = node.RightNode;

            //starting at the right child we go down every left child node
            while(current != null)
            {
                parentOfSuccessor = successor;
                successor = current;
                current = current.LeftNode;
            }

            //if the successor is not just the right node then
            if(successor != node.RightNode)
            {
                //set the left node on the parent node of the successor node to the right child node of the successor in case it has one
                parentOfSuccessor.LeftNode = successor.RightNode;

                //attach the right child node of the node being deleted to the successors right node
                successor.RightNode = node.RightNode;

            }

            //attach the left child node of the node being deleted to the successors of the left node
            successor.LeftNode = node.LeftNode;

            return successor;
        }


        //Number return in ascending order
        //Left->Root->Right nodes recursively of each syb tree
        public void InOrderTraversal()
        {
            InOrderTraversalRecursive(root);
        }

        private void InOrderTraversalRecursive(BSTNode node)
        {
            if(node.LeftNode != null)
            {
                InOrderTraversalRecursive(node.LeftNode);
            }

            Console.WriteLine(node.Data);

            if(node.RightNode != null)
            {
                InOrderTraversalRecursive(node.RightNode);
            }

        }

        //Root->Left-Right nodes recursively of each subtree
        public void PreOrderTraversal()
        {
            PreOrderTraversalRecursive(root);
        }

        private void PreOrderTraversalRecursive(BSTNode node)
        {
            Console.WriteLine(node.Data);

            if (node.LeftNode != null)
            {
                PreOrderTraversalRecursive(node.LeftNode);
            }

            if (node.RightNode != null)
            {
                PreOrderTraversalRecursive(node.RightNode);
            }
        }

        //Left-Right-Root nodes recursively of each subtree
        public void PostOrderTraversal()
        {
            PostOrderTraversalRecursive(root);
        }

        private void PostOrderTraversalRecursive(BSTNode node)
        {
            if (node.LeftNode != null)
            {
                PostOrderTraversalRecursive(node.LeftNode);
            }

            if (node.RightNode != null)
            {
                PostOrderTraversalRecursive(node.RightNode);
            }

            Console.WriteLine(node.Data);
        }
    }
}
