using ChessApp.Game_Engin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.View_Engin
{
    public class SquareView
    {
        Square aSquare;

        public SquareView(Square pSquare)
        {
            aSquare = pSquare;
        }
        
        public Image GetImage()
        {
            if (aSquare.HasPiece())
            {
                Piece aPiece = aSquare.GetPiece();
                if (aPiece.GetColor() == Piece.Color.BLACK)
                {
                    if (aPiece.GetPieceType() == Piece.PieceType.PAWN)
                    {
                        return new Bitmap(Properties.Resources.blackPawn);
                    }
                    else if (aPiece.GetPieceType() == Piece.PieceType.ROOK)
                    {
                        return new Bitmap(Properties.Resources.blackRook);
                    }
                    else if (aPiece.GetPieceType() == Piece.PieceType.KNIGHT)
                    {
                        return new Bitmap(Properties.Resources.blackKinght);
                    }
                    else if (aPiece.GetPieceType() == Piece.PieceType.BISHOP)
                    {
                        return new Bitmap(Properties.Resources.blackBishop);
                    }
                    else if (aPiece.GetPieceType() == Piece.PieceType.QUEEN)
                    {
                        return new Bitmap(Properties.Resources.blackQueen);
                    }
                    else if (aPiece.GetPieceType() == Piece.PieceType.KING)
                    {
                        return new Bitmap(Properties.Resources.blackKing);
                    }
                }
                else
                {
                    if (aPiece.GetPieceType() == Piece.PieceType.PAWN)
                    {
                        return new Bitmap(Properties.Resources.whitePawn);
                    }
                    else if (aPiece.GetPieceType() == Piece.PieceType.ROOK)
                    {
                        return new Bitmap(Properties.Resources.whiteRook);
                    }
                    else if (aPiece.GetPieceType() == Piece.PieceType.KNIGHT)
                    {
                        return new Bitmap(Properties.Resources.whiteKnight);
                    }
                    else if (aPiece.GetPieceType() == Piece.PieceType.BISHOP)
                    {
                        return new Bitmap(Properties.Resources.whiteBishop);
                    }
                    else if (aPiece.GetPieceType() == Piece.PieceType.QUEEN)
                    {
                        return new Bitmap(Properties.Resources.whiteQueen);
                    }
                    else if (aPiece.GetPieceType() == Piece.PieceType.KING)
                    {
                        return new Bitmap(Properties.Resources.whiteKing);
                    }
                }
            }
            return null;

        }


        public void drawPiece(Graphics g, Point position)
        {
            g.DrawImage(GetImage(), position.X, position.Y, PositionAndPixels.square, PositionAndPixels.square);
        }

    }
}
