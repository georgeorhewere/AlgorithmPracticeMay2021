using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPracticeMay2021
{
    public class ExerciseM
    {

        public int solution(string S, int[] C)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int costs = 0;
            // loop through the string length
            for(int x =0; x < S.Length - 1; x++)
            {
                // get next character in string
                int next = x + 1;
                // check the string length is not exceeded
                if(next< S.Length)
                {
                    Console.WriteLine($"current {S[x]} next {S[next]}");
                    // compare characters
                    if (S[x] == S[next])
                    {
                        // add lowest cost to total cost
                        costs += C[x] < C[next] ? C[x] : C[next];
                    }
                }
            }
            Console.WriteLine($"Final Cost is {costs}");
            return 1;
        }
    }
    public class Tree2
    {
        public int x;
        public Tree2 l;
        public Tree2 r;
        public Tree2(int _data)
        {
            x = _data;
        }
        public Tree2(int _data, Tree2 left, Tree2 right)
        {
            x = _data;
            l = left;
            r = right;
        }
    };
}
