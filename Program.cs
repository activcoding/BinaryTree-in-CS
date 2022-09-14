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

            //Inverts the binary tree
            //          tree.InvertTree(treeRoot: tree.root!);
            //          tree.DisplayNodes();
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

            Node leftChildLeft = new Node();
            leftChildLeft.Data = 22;
            Node leftChildRight = new Node();
            leftChildRight.Data = 51;
            Node rightChildLeft = new Node();
            rightChildLeft.Data = 99;
            Node rightChildRight = new Node();
            rightChildRight.Data = 122;

            rootNode.Data = 1;
            rootNode.Left = leftChild;
            rootNode.Right = rightChild;
            leftChild.Left = leftChildLeft;
            leftChild.Right = leftChildRight;
            rightChild.Left = rightChildLeft;
            rightChild.Right = rightChildRight;

            leftChild.Data = 5;
            rightChild.Data = 20;

            root = rootNode;
        }

        public Node InvertTree(Node treeRoot)
        {
            if (treeRoot == null)
            {
                return treeRoot!;
            }

            Node left = InvertTree(treeRoot: treeRoot.Left!);
            Node right = InvertTree(treeRoot: treeRoot.Right!);

            treeRoot.Left = right;
            treeRoot.Right = left;

            return treeRoot;
        }
    }
}
