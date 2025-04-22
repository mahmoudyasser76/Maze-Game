using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolver
{
    public class BFS
    {
        private Cell[,] grid;
        private int rows, cols;
        private Form1 form;

        public BFS(Cell[,] grid, int rows, int cols, Form1 form)
        {
            this.grid = grid;
            this.rows = rows;
            this.cols = cols;
            this.form = form;
        }

        public async Task Solve(Cell startCell, Cell endCell)
        {
            var queue = new Queue<Cell>();
            queue.Enqueue(startCell);
            startCell.IsVisited = true;

            while (queue.Count > 0)
            {
                var currentCell = queue.Dequeue();

                if (currentCell == endCell)
                {
                    await TracePath(currentCell);
                    return;
                }

                foreach (var neighbor in GetNeighbors(currentCell))
                {
                    if (!neighbor.IsVisited && !neighbor.IsWall)
                    {
                        neighbor.IsVisited = true;
                        neighbor.Parent = currentCell;
                        queue.Enqueue(neighbor);
                    }
                }
                form.Invalidate();
                await Task.Delay(15);
            }
            MessageBox.Show("No path found!");
        }

        private List<Cell> GetNeighbors(Cell cell)
        {
            var neighbours = new List<Cell>();
            int[] dx = { -1, 0, 1, 0 };
            int[] dy = { 0, -1, 0, 1 };

            for (int i = 0; i < 4; i++)
            {
                int nx = cell.X + dx[i];
                int ny = cell.Y + dy[i];

                if (nx >= 0 && nx < rows && ny >= 0 && ny < cols)
                {
                    neighbours.Add(grid[nx, ny]);
                }

            }
            return neighbours;
        }
        private async Task TracePath(Cell endCell)
        {
            Cell current = endCell;
            Stack<Cell> path = new Stack<Cell>();
            while (current != null)
            {
                path.Push(current);
                current = current.Parent;
            }

            while (path.Count > 0)
            {
                var cell = path.Pop();
                cell.IsPath = true;
                form.Invalidate();
                await Task.Delay(15);
            }

            MessageBox.Show("Path found!🎉");

        }
    }
}
