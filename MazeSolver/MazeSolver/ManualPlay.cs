using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolver
{
    public class ManualPlay
    {
        private Cell[,] grid;
        private Cell player;
        private int rows, cols;
        private Form1 form;

        public ManualPlay(Cell[,] grid, Cell player, int rows, int cols, Form1 form)
        {
            this.grid = grid;
            this.player = player;
            this.rows = rows;
            this.cols = cols;
            this.form = form;

            form.KeyDown += HandleKeyPress;
        }

        public void HandleKeyPress(object sender, KeyEventArgs e)
        {
            int newX = player.X;
            int newY = player.Y;

            switch (e.KeyCode)
            {
                case Keys.W:
                    newX -= 1;
                    break;
                case Keys.S:
                    newX += 1;
                    break;
                case Keys.A:
                    newY -= 1;
                    break;
                case Keys.D:
                    newY += 1;
                    break;
            }

            if (newX >= 0 && newX < rows && newY >= 0 && newY < cols)
            {
                if (!grid[newX, newY].IsWall)
                {
                    player = grid[newX, newY];
                    player.IsVisited = true;

                    form.SetPlayer(player);

                    if (player.IsEnd)
                    {
                        MessageBox.Show("You reached the end!🎉");
                    }
                }
            }
        }

        public void Detach()
        {
            form.KeyDown -= HandleKeyPress;
        }
    }
}
