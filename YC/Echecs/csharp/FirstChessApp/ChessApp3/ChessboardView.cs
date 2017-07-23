using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoubleBuff
{
    // TODO needs to be derived from IView TDB
    class ChessboardView
    {

        private void DrawBoard(Graphics g)
        {
            // TODO: dim of the controls need to passed as a rendering context to the view
            int boardPanel_x = 0;// g.Width;
            int boardPanel_y = 800;// g.Height;

            int square_x = boardPanel_x / 9;
            int square_y = boardPanel_y / 9;
            int square = Math.Min(square_x, square_y);
            Pen mainPen = new Pen(Color.Black, 1);

            for (int i = 0; i < 9; i++)
            {
                // Vertical lines
                Point p1 = new Point(square / 2, square / 2 + square * i);
                Point p2 = new Point(square / 2 + square * 8, square / 2 + square * i);
                g.DrawLine(mainPen, p1, p2);

                // Horizontal lines
                Point p3 = new Point(square / 2 + square * i, square / 2);
                Point p4 = new Point(square / 2 + square * i, square / 2 + square * 8);
                g.DrawLine(mainPen, p3, p4);

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int p1 = square / 2 + (2 * i * square);
                    int p2 = square / 2 + (2 * j * square);
                    g.FillRectangle(Brushes.Black, p1, p2, square, square);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int p1 = square / 2 + square + (2 * i * square);
                    int p2 = square / 2 + square + (2 * j * square);
                    g.FillRectangle(Brushes.Black, p1, p2, square, square);
                }
            }
            bool showBoardAnnotation = true;
            Font myFont = new Font("Arial", 16);

            if (showBoardAnnotation)
            {
                for (int i = 1; i < 9; i++)
                {
                    g.DrawString((9 - i).ToString(), myFont, Brushes.Black, square / 16, square * i - (square / 4));
                    g.DrawString(Char.ConvertFromUtf32(65 + i - 1), myFont, Brushes.Black, square * i - (square / 4), square / 16);
                }
            }
        }
    }
}
