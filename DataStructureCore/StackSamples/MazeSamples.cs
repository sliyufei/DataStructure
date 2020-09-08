using System;
using DataStructureCore.StackSamples.LinkStackSamples;

namespace DataStructureCore.StackSamples
{
    public class MazeSamples
    {
        private int exitX;

        private int exitY;

        private int[,] maze;

        /// <summary>
        /// 0 可以走  1不可以走
        /// </summary>
        public MazeSamples()
        {
            exitX = 8;
            exitY = 10;
            maze = new int[,]
            {
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1},
                {1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1},
                {1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1},
                {1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1},
                {1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1},
                {1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1},
                {1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
            };
        }


        public void PrintMaze()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(maze[i, j]);
                }

                Console.WriteLine();
            }
        }

        public void Move()
        {
            var x = 1;
            var y = 1;
            var linkStack = new LinkStack<Step>();

            maze[1, 1] = 2;
            while (x <= exitX && y <= exitY)
            {
                if (x == exitX && y == exitY)
                    return;

                if (maze[x - 1, y] == 0)
                {
                    x -= 1;
                    linkStack.Push(new Node<Step>(new Step {X = x, Y = y}));
                }
                else if (maze[x + 1, y] == 0)
                {
                    x += 1;
                    linkStack.Push(new Node<Step>(new Step {X = x, Y = y}));
                }
                else if (maze[x, y - 1] == 0)
                {
                    y -= 1;
                    linkStack.Push(new Node<Step>(new Step {X = x, Y = y}));
                }
                else if (maze[x, y + 1] == 0)
                {
                    y += 1;
                    linkStack.Push(new Node<Step>(new Step {X = x, Y = y}));
                }
                else
                {
                    var stepNode = new Node<Step>();
                    linkStack.Pop(out stepNode);

                    if (x == stepNode.Data.X && y == stepNode.Data.Y)
                        linkStack.Pop(out stepNode);

                    x = stepNode.Data.X;
                    y = stepNode.Data.Y;
                }

                maze[x, y] = 2;
            }
        }

        public void PrintTrace()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(maze[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}