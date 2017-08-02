using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public static class PositionAndPixels
    {
        public static int boardPanel_x;
        public static int boardPanel_y;
        public static int square;
        static int square_x, square_y;
       
        public static void Set(int width, int height)
        {
            boardPanel_x = width;
            boardPanel_y = height;
            Update();
        }
        public static void Update()
        {
            square_x = boardPanel_x / 9;
            square_y = boardPanel_y / 9;
            square = Math.Min(square_x, square_y);
        }

        public static BoardPosition PixelsToBoardPosition(Point pt)
        {
            int x = (pt.X - (square / 2)) / square;
            int y = (pt.Y - (square / 2)) / square;

            return new BoardPosition(x, y);
        }

        public static Point BoardPositionToPixels(BoardPosition m)
        {
            int x = square * m.X + (square / 2);
            int y = square * m.Y + (square / 2);

            return new Point(x, y);
        }

    }
}
