using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace life2
{
    public partial class frmLife : Form
    {
        public frmLife()
        {
            InitializeComponent();
        }

        private void frmLife_Load(object sender, EventArgs e)
        {
            
        }

        private void frmLife_ResizeEnd(object sender, EventArgs e)
        {
            tmrCheck.Enabled = true;
        }

        private void frmLife_Resize(object sender, EventArgs e)
        {
        }

        private void frmLife_Shown(object sender, EventArgs e)
        {
            tmrCheck.Enabled = true;
        }

        private bool CheckNeighbors(int x, int y)
        {
            int neighbors = 0;

            if ((x >= 0) && (x <= gpLife.Width) && (y >= 0) && (y <= gpLife.Height))
            {
                //think of a checkerboard.  we are looking at a square on the board.  we want to know whats in all the surrounding
                //squares. so we start in the upper left corner x-1, y-1; and we end in the lower right corner: x+1, y+1.
                int xStart = (x - 1);
                int xEnd = (x + 1);
                int yStart = (y - 1);
                int yEnd = (y + 1);

                //if we are looking at the square surrounding a corner or along the top row, then set the start and end
                //values accordingly.
                if (x == 0)
                {
                    xStart = 0;
                }
                if (x == (gpLife.gridMemory.GetLength(0) - 1))
                {
                    xEnd = x;
                }

                if (y == 0)
                {
                    yStart = 0;
                }
                if (y == (gpLife.gridMemory.GetLength(1) - 1))
                {
                    yEnd = y;
                }


                for (int a = xStart; a <= xEnd; a++)
                {
                    for (int b = yStart; b <= yEnd; b++)
                    {
                        if (!((x == a) && (y == b)))
                        {
                            if (gpLife.gridMemory[a, b].filled)
                            {
                                neighbors++;
                            }
                        }
                    }
                }

                //rules
                //1.  Any live cell with fewer than two live neighbours dies, as if caused by under-population.
                //2.  Any live cell with two or three live neighbours lives on to the next generation.
                //3.  Any live cell with more than three live neighbours dies, as if by over - population.
                //4.  Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                if (gpLife.gridMemory[x, y].filled)
                {
                    switch (neighbors)
                    {
                        case 0:
                        case 1:
                            {
                                return false;
                            }
                        case 2:
                        case 3:
                            {
                                return true;
                            }
                        default:
                            {
                                return false;
                            }
                    }
                }
                else
                {
                    if (neighbors == 3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            tmrCheck.Enabled = false;

            bool[,] newGrid = new bool[gpLife.gridMemory.GetLength(0), gpLife.gridMemory.GetLength(1)];

            for (int x = 0; x <= gpLife.gridMemory.GetLength(0) - 1; x++)
            {
                for (int y = 0; y <= gpLife.gridMemory.GetLength(1) - 1; y++)
                {
                    newGrid[x, y] = CheckNeighbors(x, y);
                }
            }

            for (int x = 0; x <= gpLife.gridMemory.GetLength(0)-1; x++)
            {
                for (int y = 0; y <= gpLife.gridMemory.GetLength(1)-1; y++)
                {
                    if (newGrid[x, y])
                    {
                        gpLife.FillSquare(x, y);
                    }
                    else
                    {
                        gpLife.EmptySquare(x, y);
                    }
                }
            }

            tmrCheck.Enabled = true;
        }

        private void frmLife_ResizeBegin(object sender, EventArgs e)
        {
            tmrCheck.Enabled = false;
        }
    }
}
