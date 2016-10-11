using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphPaperGrid
{
    public partial class GraphPaper : UserControl
    {
        int CELLSIZE = 10;

        public struct gridLocation
        {
            public bool filled;
            public int x;
            public int y;
            public Rectangle box;
        }

        public gridLocation[,] gridMemory;

        public GraphPaper()
        {
            InitializeComponent();
        }

        private void GraphPaper_Load(object sender, EventArgs e)
        {

        }

        public void FillSquare(int x, int y)
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Graphics g = pbGrid.CreateGraphics();

            g.FillRectangle(redBrush, gridMemory[x, y].box);
            gridMemory[x, y].filled = true;

            ControlPaint.DrawBorder(g, gridMemory[x, y].box, Color.Black, ButtonBorderStyle.Solid);

            g.Dispose();
            redBrush.Dispose();
        }

        public void EmptySquare(int x, int y)
        {
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Graphics g = pbGrid.CreateGraphics();

            g.FillRectangle(whiteBrush, gridMemory[x, y].box);
            gridMemory[x, y].filled = false;

            ControlPaint.DrawBorder(g, gridMemory[x, y].box, Color.Black, ButtonBorderStyle.Solid);

            g.Dispose();
            whiteBrush.Dispose();
        }

        private void pbGrid_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);
            int arrayX = 0;
            int arrayY = 0;

            for (int x = 0; x <= pbGrid.Width; x++)
            {
                //e.Graphics.DrawLine(p, x * CELLSIZE, 0, x * CELLSIZE, pbGrid.Width);
                arrayX = x;
            }
            for (int y = 0; y <= pbGrid.Height; y++)
            {
                //e.Graphics.DrawLine(p, 0, y * CELLSIZE, pbGrid.Width, y * CELLSIZE);
                arrayY = y;
            }

            gridMemory = new gridLocation[arrayX, arrayY];

            e.Graphics.DrawLine(p, 0, pbGrid.Height - 1, pbGrid.Width - 1, pbGrid.Height - 1);
            e.Graphics.DrawLine(p, pbGrid.Width - 1, 0, pbGrid.Width - 1, pbGrid.Height - 1);

            //now create the grid in memory and name each space.
            Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            SolidBrush redBrush = new SolidBrush(Color.Red);

            //using (Bitmap bmpGrid = new Bitmap(pbGrid.Image))
            //{
            for (int a = 0; a <= (pbGrid.Width / CELLSIZE); a++)
            {
                for (int b = 0; b <= (pbGrid.Height / CELLSIZE); b++)
                {
                    gridMemory[a, b].filled = (rand1.Next(1, 101) <= 50);
                    gridMemory[a, b].box = new Rectangle(a * CELLSIZE, b * CELLSIZE, CELLSIZE, CELLSIZE);

                    if (gridMemory[a, b].filled == true)
                    {
                        e.Graphics.FillRectangle(redBrush, gridMemory[a, b].box);
                    }


                    ControlPaint.DrawBorder(e.Graphics, gridMemory[a, b].box, Color.Black, ButtonBorderStyle.Solid);
                }
            }

            //}
        }
    }
}
