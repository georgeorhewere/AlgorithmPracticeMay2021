using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPracticeMay2021.Tree
{
    public class BinaryTreeMoves
    {
        private int _target;
        private Node root;
        private int moves;

        public BinaryTreeMoves()
        {
            root = new Node(0, new Node(0), new Node(1));
            
        }

        public void findMoves(int target)
        {            
            _target = target;
            moves = 0;
            checkNode(target, root, root.Left.Data, root.Right.Data);
           // printNode(root);
        }

        public void checkNode(int target, Node node, int currentLeft, int currentRight)
        {
            moves++;
            //if (moves > 5)
            //    return;

            if (node != null)
            {
                Console.WriteLine($"Check Node { node.Data }");
                if (target == node.Data)
                {
                    Console.WriteLine($"Found Node");
                    return;
                }
                else
                {
                    if (target < 0 && node.Data < target)
                    {
                        Console.WriteLine($"Past expected Value");
                        
                    }
                    else
                    {
                        if (node.Left == null && node.Right == null)
                        {
                            node.GenerateLeftChildren(currentLeft, currentRight);
                            //node.GenerateRightChildren(currentLeft, currentRight);
                        }

                        checkNode(target, node.Left, node.Left.Data, node.Right.Data);
                        // checkNode(target, node.Right, node.Left.Data, node.Right.Data);
                    }
                }
            }
        }

        public void printNode(Node node)
        {
            if(node != null)
            {
                printNode(node.Left);
                Console.WriteLine($"node is { node.Data } ");                
                printNode(node.Right);
            }
        }

        public Node  Root { get { return root; } }
    }

    public class Node
    {
        private int data;
        private Node leftNode;
        private Node rightNode;
        
        public Node(int _data)
        {
            data = _data;
        }
        public Node(int _data, Node left, Node right)
        {
            data = _data;
            leftNode = left;
            rightNode = right;
        }


        public void GenerateLeftChildren(int left, int right)
        {
            generateLeft(left, right);
            Console.WriteLine($"left : {leftNode.Data} right : { rightNode.Data } ");
        }
        public void GenerateRightChildren(int left, int right)
        {
            generateRight(left, right);
        }
        private void generateLeft(int left, int right)
        {
            int nodeValue = (2 * left) - right;
            leftNode = new Node(nodeValue);
            rightNode = new Node(right);
        }
        private void generateRight(int left, int right)
        {
            int nodeValue = (2 * right) - left;
            rightNode = new Node(nodeValue);
            leftNode = new Node(left);
        }
        public int Data { get { return data;  } }
        public Node Left { get { return leftNode; } }
        public Node Right { get { return rightNode; } }
    }
}
