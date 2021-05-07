using AlgorithmPracticeMay2021.Tree;
using System;
using System.Collections.Generic;

namespace AlgorithmPracticeMay2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tree Practice");
            //TestTrees();
            //TestBettingGame();
            TestExercise2();

        }

        public static void TestExercise()
        {
            ExerciseM game = new ExerciseM();
            string S = "aaaa"; //"aabbcc"; //"abccbd";
            int[] costs = { 3, 4, 5, 6 };//{1,2,1,2,1,2 }; // { 0,1,2,3,4,5};
            game.solution(S,costs);
        }
        public static void TestExercise2()
        {
            Tree2 root = new Tree2(1, new Tree2(2), new Tree2(3));
            root.l.l = new Tree2(3);
            root.l.l.l = new Tree2(2);
            root.l.r = new Tree2(6);
            // rigth nodes 
            root.r.l = new Tree2(3);
            root.r.r = new Tree2(1);
            root.r.r.l = new Tree2(5);
            root.r.r.r = new Tree2(6);
            Console.WriteLine($"node : {root.x}");
            // print lefts
            Console.WriteLine($"Left Paths");
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            dictionary.Add(root.x, 1);
            checkNodes(root.l,dictionary,true);
            // print rights
            Console.WriteLine($"Right Paths");
            dictionary = new Dictionary<int, int>();
            dictionary.Add(root.x, 1);
            checkNodes(root.r,dictionary, false);
        }

        private static void PrintTree(Tree2 root, bool isLeft)
        {
            if (root == null)
                return;
            Console.WriteLine($"node : {root.x} {(isLeft ? "Left" :" Right" )}" );
            //Print Left
            //checkNodes(root.l,true);
            //print right
            // PrintTree(root.r, false);

        }
        private static void checkNodes(Tree2 node, Dictionary<int, int> dictionary, bool isLeft)
        {   
            while(node != null)
            {
                if (!dictionary.ContainsKey(node.x))
                    dictionary.Add(node.x, 1);
                else
                    break;
                //check left
                //
                if (isLeft)
                {
                    if (node.l != null && !dictionary.ContainsKey(node.l.x))
                    {
                        node = node.l;
                    }
                    else if (node.r != null && !dictionary.ContainsKey(node.r.x))
                    {
                        node = node.r;

                    }
                    else
                    {
                        node = null;
                    }
                }
                else
                {
                    if (node.r != null && !dictionary.ContainsKey(node.r.x))
                    {
                        node = node.r;
                    }
                    else if (node.l != null && !dictionary.ContainsKey(node.l.x))
                    {
                        node = node.l;
                    }
                    else
                    {
                        node = null;
                    }

                }
            }

            foreach (var key in dictionary.Keys)
                Console.Write($"{key}, ");
            Console.WriteLine();

            Console.WriteLine($"Distinct path { dictionary.Keys.Count }, ");

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
