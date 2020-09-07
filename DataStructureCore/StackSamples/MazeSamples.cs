using System;

namespace DataStructureCore.StackSamples
{
    public class MazeSamples
    {
        private int exitX;

        private int exitY;

        private int[,] maze;

        public MazeSamples()
        {
            exitX = 8;
            exitY = 10;
            maze = new int[,]
            {
                {1,1,1,1,1,1,1,1,1,1,1,1},
                {1,0,0,0,1,1,1,1,1,1,1,1},
                {1,1,1,0,1,1,0,0,0,0,1,1},
                {1,1,1,0,1,1,0,1,1,0,1,1},
                {1,1,1,0,0,0,0,1,1,0,1,1},
                {1,1,1,0,1,1,0,1,1,0,1,1},
                {1,1,1,0,1,1,0,1,1,0,1,1},
                {1,1,1,1,1,1,0,1,1,0,1,1},
                {1,1,0,0,0,0,0,0,1,0,0,1},
                {1,1,1,1,1,1,1,1,1,1,1,1}
            };

        }


        public void PrintMaze()
        {
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (maze[i,j]==0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                    
                }
                Console.WriteLine();
            }
        }



    }
}