using static AutoBattle.Types;
using System.Collections.Generic;
using System;

namespace AutoBattle
{
    public class Grid
    {
        public List<GridBox> grids = new List<GridBox>();
        public int xLength;
        public int yLength;

        public Grid(int lines, int columns)
        {
            xLength = lines;
            yLength = columns;
            Console.WriteLine("The battlefield has been created\n");

            for (int i = 0; i < xLength; i++)
            {
                for (int j = 0; j < yLength; j++)
                {
                    GridBox newBox = new GridBox(j, i, false, (yLength * i + j));
                    grids.Add(newBox);
                }
            }
        }
        // prints the matrix that indicates the tiles of the battlefield
        public void drawBattlefield()
        {
            for (int i = 0; i < xLength; i++)
            {
                for (int j = 0; j < yLength; j++)
                {
                    int index = yLength * i + j;

                    if (grids[index].ocupied)
                        Console.Write($"[X]\t");
                    else
                        Console.Write($"[ ]\t");
                        // Console.Write($"[{grids[index].xIndex},{grids[index].yIndex}]\t");
                        //intead, you can also use to debug the matrix battlefield
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    }
}
