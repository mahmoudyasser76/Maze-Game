using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolver
{
    public partial class Form1 : Form
    {
        Cell[,] grid;
        int rows = 20;
        int cols = 20;
        int cellSize = 25;

        Cell startCell;
        Cell endCell;

        Cell player;

        private void GenerateMaze()
        {
            grid = MazeGenerator.Generate(rows, cols, out startCell, out endCell);
            player = startCell;
            panel1.Invalidate();
        }
        public Form1()
        {
            InitializeComponent();
            GenerateMaze();
        }

        // Manual Mode
        ManualPlay manualPlay;
        public void SetPlayer(Cell cell)
        {
            player = cell;
            panel1.Invalidate();
        }

        private void btnManualPlay_Click(object sender, EventArgs e)
        {
            ClearGrid();
            manualPlay?.Detach();
            manualPlay = new ManualPlay(grid, player, rows, cols, this);
            this.Focus();
        }


        // Algorithm Mode "BFS"
        private async void btnSolveBFS_Click(object sender, EventArgs e)
        {

            foreach (var cell in grid)
            {
                cell.IsVisited = false;
                cell.Parent = null;
            }
            ClearGrid();
            BFS bfsSolver = new BFS(grid, rows, cols, this);
            await bfsSolver.Solve(startCell, endCell);
            panel1.Invalidate();
             
        }

        // Algorithm Mode "DFS"
        private async void btnSolveDFS_Click(object sender, EventArgs e)
        {
            foreach (var cell in grid)
            {
                cell.IsVisited = false;
                cell.Parent = null;
            }
            ClearGrid();
            DFS dFSSolver = new DFS(grid, rows, cols, this);
            await dFSSolver.Solve(startCell, endCell);
            panel1.Invalidate();
        }

        // Algorithm Mode "A*"
        private async void btnSolveAStar_Click(object sender, EventArgs e)
        {
            foreach (var cell in grid)
            {
                cell.IsVisited = false;
                cell.Parent = null;
            }
            ClearGrid();
            AStar astar = new AStar(grid, rows, cols, this);
            await astar.Solve(startCell, endCell);
            panel1.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GenerateMaze();
        }

        // to drow the maze
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (grid == null)
                return;

            Graphics g = e.Graphics;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Cell c = grid[i, j];
                    Brush brush;

                    if (c.IsWall)
                        brush = Brushes.Black;

                    else if (c.IsStart)
                        brush = Brushes.Green;

                    else if (c.IsEnd)
                        brush = Brushes.Red;

                    else if (c.IsPath)
                        brush = Brushes.Orange;

                    else if (c == player)
                        brush = Brushes.Blue;

                    else if (c.IsVisited)
                        brush = Brushes.Yellow;

                    else
                        brush = Brushes.White;

                    g.FillRectangle(brush, j * cellSize, i * cellSize, cellSize, cellSize);
                    g.DrawRectangle(Pens.Gray, j * cellSize, i * cellSize, cellSize, cellSize);

                }
            }

        }

        public void ClearGrid() 
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j].IsVisited = false;
                    grid[i, j].IsPath = false;
                    grid[i, j].Parent = null;
                }
            }
            panel1.Invalidate();
        }
    }
}
