using System;

namespace BinaryTree
{
    class Programm
    {
        static void Main(string[] args)
        {
            binaryTree tree = new binaryTree();
            tree.Insert();
            tree.DisplayNodes();

        }
    }

    public class binaryTree
    {
        public class Node
        {
            public int Data;
            public Node? Left;
            public Node? Right;

            public void writeNode()
            {
                Console.WriteLine(Data);
                Left?.writeNode();
                Right?.writeNode();
            }
        }

        public void DisplayNodes()
        {
            Console.WriteLine(root?.Data);
            root?.Left?.writeNode();
            root?.Right?.writeNode();
        }

        public Node? root;

        public void Insert()
        {
            Node rootNode = new Node();
            Node rightChild = new Node();
            Node leftChild = new Node();

            rootNode.Data = 1;
            rootNode.Left = leftChild;
            rootNode.Right = rightChild;

            leftChild.Data = 5;
            rightChild.Data = 20;

            root = rootNode;
        }
    }
}
