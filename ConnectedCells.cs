using System;

namespace HackerRankCode
{
    class ConnectedCells
    {
        /*Given an n x m matrix, find and print the number of cells in the largest region of 1s in the matrix. Note that there may be more than one region in the matrix.
         */

        //Simple recursive method to find all the adjacent 1s in the matrix
        private int cells(int i, int j, int[][] matrix, int n, int m)
        {
            if (((i < 0 || j < 0) || (i >= n || j >= m)) || matrix[i][j] == 0 || matrix[i][j] == -1)
                return 0;
            //once visited, mark it as -1, so as to avoid repeated consideration
            matrix[i][j] = -1;

            //Look into all nearest cells of the matrix
            return 1 + cells(i - 1, i - 1, matrix, n, m) + cells(i - 1, j, matrix, n, m) + cells(i - 1, j + 1, matrix, n, m) + cells(i, j - 1, matrix, n, m) + cells(i, j + 1, matrix, n, m) + cells(i + 1, j - 1, matrix, n, m) + cells(i + 1, j, matrix, n, m) + cells(i + 1, j + 1, matrix, n, m);
        }

        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int matrix_i = 0; matrix_i < n; matrix_i++)
            {
                string[] matrix_temp = Console.ReadLine().Split(' ');
                matrix[matrix_i] = Array.ConvertAll(matrix_temp, Int32.Parse);
            }
            int result = 0;

            //For all the 1s present in the matrix, which are univisted, find adjacent 1s and fianlly return the maximum.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] == 1)
                        result = Math.Max(result, cells(i, j, matrix, n, m));
                }
            }
            Console.WriteLine(result);
        }
    }
}
