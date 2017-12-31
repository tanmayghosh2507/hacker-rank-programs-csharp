using System;

namespace HackerRankCode
{
    class JourneyToMoon
    {
        /*
         * Graph Theory Problem:
         * Given number of astronauts and pairs of astronauts in 2D array form; those 2 astronauts
         * belong to same country.
         * Output: Total number of possible combinations of astronauts where both
         * astronauts belong to different country.
         */ 
        public int journeyToMoon(int n, int[][] astronaut)
        {
            //Each astronaut corresponds to a vertex in graph.
            Graph graph = new Graph(n);

            //Creating all the edges of the graph by joining the vertices corresponding
            //to astronauts from same country.
            for(int i=0; i<astronaut.Length; i++)
                graph.AddEdge(astronaut[i][0], astronaut[i][1]);

            //This result returns an array where elements are number of sets of astronauts 
            //from same country.
            int[] res = graph.DFS();

            //The total number of pairs can be calculated as choosing one astronaut from one country
            //and another one from any other country.
            int sum = 0;
            for(int i=0; i<res.Length; i++)
            {
                //Once we reach 0. There is no point of further calculation.
                if (res[i+1] == 0)
                    break;
                for(int j=i+1; j<res.Length; j++)
                    sum += res[i] * res[j];
            }

            return sum;
        }
    }
}
