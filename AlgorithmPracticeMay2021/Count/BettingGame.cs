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
            int remainder = 0;
            do
            {
                remainder = N / 2;
                count++;
                Console.WriteLine($"count { count } remainder {remainder}");

            } while (count < K && remainder > 2);

            return 1;
        }
    }
}
