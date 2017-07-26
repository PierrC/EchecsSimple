using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class PieceView
    {
        Piece aPiece;
        Image aImage;

        public PieceView(Piece pPiece)
        {
            aPiece = pPiece;
            aImage = SetImage();
        }

        private Image SetImage()
        {
            if (aPiece.getColor().Equals(Piece.Color.BLACK))
            {
                if (aPiece.getPieceType().Equals(Piece.PieceType.PAWN))
                {
                    return new Bitmap(Properties.Resources.blackPawn);
                }
                else if (aPiece.getPieceType().Equals(Piece.PieceType.ROOK))
                {
                    return new Bitmap(Properties.Resources.blackRook);
                }
                else if (aPiece.getPieceType().Equals(Piece.PieceType.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.blackKinght);
                }
                else if (aPiece.getPieceType().Equals(Piece.PieceType.BISHOP))
                {
                    return new Bitmap(Properties.Resources.blackBishop);
                }
                else if (aPiece.getPieceType().Equals(Piece.PieceType.QUEEN))
                {
                    return new Bitmap(Properties.Resources.blackQueen);
                }
                else if (aPiece.getPieceType().Equals(Piece.PieceType.KING))
                {
                    return new Bitmap(Properties.Resources.blackKing);
                }
            }
            else
            {
                if (aPiece.getPieceType().Equals(Piece.PieceType.PAWN))
                {
                    return new Bitmap(Properties.Resources.whitePawn);
                }
                else if (aPiece.getPieceType().Equals(Piece.PieceType.ROOK))
                {
                    return new Bitmap(Properties.Resources.whiteRook);
                }
                else if (aPiece.getPieceType().Equals(Piece.PieceType.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.whiteKnight);
                }
                else if (aPiece.getPieceType().Equals(Piece.PieceType.BISHOP))
                {
                    return new Bitmap(Properties.Resources.whiteBishop);
                }
                else if (aPiece.getPieceType().Equals(Piece.PieceType.QUEEN))
                {
                    return new Bitmap(Properties.Resources.whiteQueen);
                }
                else if (aPiece.getPieceType().Equals(Piece.PieceType.KING))
                {
                    return new Bitmap(Properties.Resources.whiteKing);
                }
            }
            return null;
        }

        public Piece GetPiece()
        {
            return aPiece;
        }

        public Image GetImage()
        {
            return aImage;
        }

        public void drawImage(Graphics g, Point position)
        {
            g.DrawImage(aImage, position.X, position.Y, PositionAndPixels.square, PositionAndPixels.square);
        }

        public override string ToString()
        {
            return aPiece.ToString();
        }
    }
}
