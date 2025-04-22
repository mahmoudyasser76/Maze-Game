using System;

namespace MazeSolver
{
    public class MazeGenerator
    {
        public static Cell[,] Generate(int rows, int cols, out Cell startCell, out Cell endCell)
        {
            Cell[,] grid = new Cell[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = new Cell(i, j)
                    {
                        IsWall = rnd.Next(0, 100) < 20 // Randomly assign walls
                    };
                }
            }

            startCell = grid[0, 0];
            startCell.IsStart = true;
            startCell.IsWall = false;

            if (cols > 1) grid[0, 1].IsWall = false;
            if (rows > 1) grid[1, 0].IsWall = false;

            endCell = grid[rows - 1,cols - 1];
            endCell.IsWall = false;
            endCell.IsEnd = true;

            if (cols > 1) grid[rows - 1, cols - 2].IsWall = false;
            if (rows > 1) grid[rows - 2, cols - 1].IsWall = false;

            return grid;

        }
    }
}
