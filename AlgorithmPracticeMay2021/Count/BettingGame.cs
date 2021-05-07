using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPracticeMay2021
{
    public class BettingGame
    {


        public int minimumMoves(int N, int K)
        {
            int count = 0;
            decimal remainder = N;
            bool[] positions = new bool[K];

            while (count < K && remainder > 2)
            {
                remainder = remainder / 2;
                if (remainder > 2)
                {
                    int pos = (int)remainder;
                    positions[pos] = true;
                    count++;                  
                }
                Console.WriteLine($"count { count } remainder {remainder}");

            } ;
            Console.WriteLine($"minimum all ins count { count } ");

            for(int y = 1; y < K; y++)
            {
                if (positions[y])
                    Console.WriteLine($"count Steps to this position {y}");
            }
            
           
            

            return 1;
        }
    }
}
