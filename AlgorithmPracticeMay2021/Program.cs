using AlgorithmPracticeMay2021.Tree;
using System;

namespace AlgorithmPracticeMay2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tree Practice");

        }

        public static void TestTrees()
        {
            BinaryTreeMoves tree = new BinaryTreeMoves();
            tree.findMoves(-11);
            tree.printNode(tree.Root);
        }
    }
}
