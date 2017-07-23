using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        private int PixelMargine_ = 5;

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
        public Position GetPostionFromPoint(int rowPixel, int columnPixel)
        {
            // That logic might be bogus. Needs some test
            int IRow = (int)(8 * (float)PixelDimension_ / (float)rowPixel);
            int IColumn = (int)(8 * (float)PixelDimension_ / (float)columnPixel);
            return new Position(IRow, IColumn);
        }

        public Point GetPositionUpperCorner(Position iPosition)
        {
            // That logic might be bogus. Needs some test
            int IRow = PixelMargine_ + PixelSquare * iPosition.Row;
            int IColumn = PixelMargine_+ PixelSquare * (7-iPosition.Column);
            return new Point(IRow, IColumn);
        }
    }
}
