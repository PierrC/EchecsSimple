using ChessApp.Game_Engin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.View_Engin
{
    public class PieceManipulatorView
    {
        PieceManipulator aPieceManipulator;
        Pen aPen;


        public PieceManipulatorView(PieceManipulator pPieceManipulator)
        {
            aPieceManipulator = pPieceManipulator;
            aPen = new Pen(Brushes.Red, 3);
        }

        public void DrawPossibleMoves(Graphics g)
        {
            int square = PositionAndPixels.square;
            List<BoardPosition> listOfMoves = aPieceManipulator.GetListOfMoves();
            if(listOfMoves != null)
            {
                foreach (BoardPosition bp in listOfMoves)
                {
                    Point point = PositionAndPixels.BoardPositionToPixels(bp);
                    g.DrawRectangle(aPen, point.X, point.Y, square, square);
                }
            }
        }

        public void DrawPossibleMovesInverse(Graphics g)
        {
            int square = PositionAndPixels.square;
            List<BoardPosition> listOfMoves = aPieceManipulator.GetListOfMoves();
            if (listOfMoves != null)
            {
                foreach (BoardPosition bp in listOfMoves)
                {
                    Point point = PositionAndPixels.BoardPositionToPixelsInverse(bp);
                    g.DrawRectangle(aPen, point.X, point.Y, square, square);
                }
            }
        }
    }
}
