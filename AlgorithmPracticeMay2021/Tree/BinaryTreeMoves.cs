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

        public void findMoves(int target)
        {
            const int left = 0;
            const int right = 1;
            _target = target;
            root = new Node(left, left, right);
        }


        public void printNode(Node node)
        {
            if(node != null)
            {
                Console.WriteLine($"node is { node.Data } ");
            }
        }
    }

    public class Node
    {
        private int data;
        private Node leftNode;
        private Node rightNode;

        public Node(int _data, int currentLeft, int currentRight)
        {
            data = _data;
        }

        public int Data { get { return data;  } }
        public Node Left { get { return leftNode; } }
        public Node Right { get { return rightNode; } }
    }
}
