using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsWall { get; set; }
        public bool IsStart { get; set; }
        public bool IsEnd { get; set; }
        public bool IsPath { get; set; }
        public bool IsVisited { get; set; }
        public Cell Parent { get; set; }

        // For A* algorithm
        public double GCost { get; set; } // Cost from start to this cell
        public double HCost { get; set; } // Heuristic cost to end cell
        public double FCost => GCost + HCost; // Total cost
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            IsWall = false;
            IsStart = false;
            IsEnd = false;
            IsPath = false;
            IsVisited = false;
            Parent = null;
            GCost = 0;
            HCost = 0;
        }
    }
}
