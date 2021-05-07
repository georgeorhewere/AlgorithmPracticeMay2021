using AlgorithmPracticeMay2021.Tree;
using System;

namespace AlgorithmPracticeMay2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tree Practice");
            //TestTrees();
            TestBettingGame();

        }


        public static void TestBettingGame()
        {
            BettingGame game = new BettingGame();
            game.minimumMoves(10,10);
        }
        public static void TestTrees()
        {
            BinaryTreeMoves tree = new BinaryTreeMoves();
            tree.findMoves(-11);
            //tree.printNode(tree.Root);
        }
    }
}
