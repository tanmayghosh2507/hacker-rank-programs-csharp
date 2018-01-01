using System;

namespace HackerRankCode
{
    class SavePrincess
    {   
        /*
         * In a nxn grid, given a position of p(princess), and mario(m), we need to find 
         * the shortest distance along with directions to reach and rescue p from m.
         * The only directions in which m can move is UP, DOWN, LEFT and RIGHT.
         */ 
        public void displayPathtoPrincess(int n, String[] grid)
        {
            int mx = 0, my = 0, px = 0, py = 0;
            //Finding the distance along x and y axis from m to p.
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 'm')
                    {
                        mx = i;
                        my = j;
                    }
                    else if (grid[i][j] == 'p')
                    {
                        px = i;
                        py = j;
                    }
                }
            }

            int up = mx - px;
            int right = my - py;

            //Based on the direction of the distance, the movement is assigned.
            if (up >= 0)
            {
                for (int i = 0; i < up; i++)
                    Console.WriteLine("UP");
            }
            else
            {
                for (int i = 0; i < -1*up; i++)
                    Console.WriteLine("DOWN");
            }

            if (right >= 0)
            {
                for (int i = 0; i < right; i++)
                    Console.WriteLine("LEFT");
            }
            else
            {
                for (int i = 0; i < -1*right; i++)
                    Console.WriteLine("RIGHT");
            }
        }
    }
}
