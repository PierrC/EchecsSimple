using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using ChessEngine;

namespace ChessApp3
{
    /// <summary>
    /// Helper class to convert a Chessbaord Position into Pixel and vice versa
    /// </summary>
    public class PositionPixel
    {
        /// <summary>
        /// There only one dimension as the Chessboard is always square
        /// </summary>
        private int PixelDimension_ = 500;
        private int PixelMargine_ = 10;

        /// <summary>
        /// Needs to be update when the window is resized
        /// </summary>
        public int PixelDimension { set => PixelDimension_ = value; }
        public int PixelSquare
        {
            get
            {
                return (PixelDimension_ - 2*PixelMargine_)/ 8;
            }
        }

        public PositionPixel()
        {
            PixelDimension_ = 500;
        }

        /// <summary>
        /// Convert pixel to position. Usefull for drawing and picking (aka selecting a Square, a Piece
        /// </summary>
        /// <param name="rowPixel"></param>
        /// <param name="columnPixel"></param>
        /// <returns></returns>
        public Position GetPostionFromPoint(int columnPixel, int rowPixel)
        {
            double fColumn = ((double)(columnPixel - PixelMargine_)) / (double)PixelSquare;
            int IColumn = (int)Math.Floor(fColumn);
            double fRow = ((double)(rowPixel - PixelMargine_)) / (double)PixelSquare;
            int IRow = 7 - (int)Math.Floor(fRow);
            Console.WriteLine("New Postion "
                + fColumn.ToString()
                + " "
                + fRow.ToString());
            return new Position(IColumn, IRow);
        }

        public Point GetPositionUpperCorner(Position iPosition)
        {
            int IColumn = PixelMargine_+ PixelSquare * iPosition.Column;
            int IRow = PixelMargine_ + PixelSquare * (7 - iPosition.Row);
            return new Point(IColumn, IRow);
        }

        public Point GetPositionCenter(Position iPosition)
        {
            int IColumn = PixelMargine_ + PixelSquare * iPosition.Column;
            int IRow = PixelMargine_ + PixelSquare * (7 - iPosition.Row);
            return new Point(IColumn + PixelSquare / 2, IRow + PixelSquare / 2);
        }
    }
}
