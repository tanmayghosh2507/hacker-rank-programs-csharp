using System;

namespace HackerRankCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //RunAlice();
            //RunDiagonalDiff();
            RunMilitary();
            //var num = Console.ReadLine();
        }

        /*
         * Utility method to run the Alice and Bob game program
         */
        static void RunAlice()
        {
            AliceBobGame abGame = new AliceBobGame();
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = abGame.Solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));
        }

        /*
         * Utility method to run Diagonal Difference Program
         */
        static void RunDiagonalDiff()
        {
            DiagonalDifference dDifference = new DiagonalDifference();
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            Console.WriteLine(dDifference.DiagonalDiff(n, a));
        }

        /*
         * Utility method to run Time Conversion Program
         */
        static void RunMilitary()
        {
            TimeConversion timeConversion = new TimeConversion();
            string s = Console.ReadLine();
            string result = timeConversion.timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
