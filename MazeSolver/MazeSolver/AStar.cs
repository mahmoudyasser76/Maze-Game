using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolver
{
    public class AStar
    {
        private Cell[,] grid;
        private int rows, cols;
        private Form1 form;

        public AStar(Cell[,] grid, int rows, int cols, Form1 form)
        {
            this.grid = grid;
            this.rows = rows;
            this.cols = cols;
            this.form = form;
        }

        public async Task Solve(Cell startCell, Cell endCell)
        {
            var openSet = new List<Cell>() { startCell };
            var closedSet = new HashSet<Cell>();

            startCell.GCost = 0;
            startCell.HCost = GetHeuristic(startCell, endCell);

            while (openSet.Count > 0)
            {
                var currentCell = openSet.OrderBy(c => c.FCost).ThenBy(c => c.HCost).First();

                if (currentCell == endCell)
                {
                    await TracePath(currentCell);
                    return;
                }

                openSet.Remove(currentCell);
                closedSet.Add(currentCell);
                currentCell.IsVisited = true;

                foreach (var neighbor in GetNeighbors(currentCell))
                {
                    if (closedSet.Contains(neighbor) || neighbor.IsWall)
                        continue;

                    double tentativeGCost = currentCell.GCost + 1;

                    if (!openSet.Contains(neighbor) || tentativeGCost < neighbor.GCost)
                    {
                        neighbor.GCost = tentativeGCost;
                        neighbor.HCost = GetHeuristic(neighbor, endCell);
                        neighbor.Parent = currentCell;

                        if (!openSet.Contains(neighbor))
                        {
                            openSet.Add(neighbor);
                        }
                    }
                }
                form.panel1.Invalidate();
                await Task.Delay(30);
            }
            MessageBox.Show("No path found");
        }

        private double GetHeuristic(Cell a, Cell b)
        {
            return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y); // Manhattan distance
        }

        private List<Cell> GetNeighbors(Cell cell)
        {
            var neighbors = new List<Cell>();
            int[] dx = { -1, 0, 1, 0 };
            int[] dy = { 0, -1, 0, 1 };

            for (int i = 0; i < 4; i++)
            {
                int nx = cell.X + dx[i];
                int ny = cell.Y + dy[i];

                if (nx >= 0 && nx < rows && ny >= 0 && ny < cols)
                {
                    neighbors.Add(grid[nx, ny]);
                }
            }
            return neighbors;

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
                form.panel1.Invalidate();
                await Task.Delay(30);
            }
            MessageBox.Show("Path found!🎉");

        }
    }
}
