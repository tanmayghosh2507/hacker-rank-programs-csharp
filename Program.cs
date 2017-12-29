﻿using System;

namespace HackerRankCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunAlice();
            //RunDiagonalDiff();
            //RunMilitary();
            RunIceCreamParlor();
            RunFunnyString();
            var num = Console.ReadLine();
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

        /*
         * Utility Method to run Ice Cream Parlor Program
         */ 
        static void RunIceCreamParlor()
        {
            int trips = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<trips; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                string[] temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(temp, Int32.Parse);
                IceCreamParlor iceCreamParlor = new IceCreamParlor();
                int[] result = iceCreamParlor.getCombination(a, m, n);
                Console.WriteLine(result[0] + " " + result[1]);
            }
        }

        /*
         * Utility method to run Funny String Program
         */ 
        static void RunFunnyString()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            FunnyString funnyString = new FunnyString();
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = funnyString.CheckFunnyString(s);
                Console.WriteLine(result);
            }
        }

        /*
         * Utility method to run GemStone Program
         */
        static void RunGemStone()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int arr_i = 0; arr_i < n; arr_i++)
                arr[arr_i] = Console.ReadLine();

            int result = gemstones(arr);
            Console.WriteLine(result);
        }
    }
}
