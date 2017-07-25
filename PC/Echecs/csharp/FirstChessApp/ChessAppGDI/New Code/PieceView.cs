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
            if (aPiece.Color == Piece.Colors.BLACK)
            {
                if (aPiece.Type == Piece.Types.PAWN)
                {
                    return new Bitmap(Properties.Resources.blackPawn);
                }
                else if (aPiece.Type.Equals(Piece.Types.ROOK))
                {
                    return new Bitmap(Properties.Resources.blackRook);
                }
                else if (aPiece.Type.Equals(Piece.Types.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.blackKinght);
                }
                else if (aPiece.Type.Equals(Piece.Types.BISHOP))
                {
                    return new Bitmap(Properties.Resources.blackBishop);
                }
                else if (aPiece.Type.Equals(Piece.Types.QUEEN))
                {
                    return new Bitmap(Properties.Resources.blackQueen);
                }
                else if (aPiece.Type.Equals(Piece.Types.KING))
                {
                    return new Bitmap(Properties.Resources.blackKing);
                }
            }
            else
            {
                if (aPiece.Type.Equals(Piece.Types.PAWN))
                {
                    return new Bitmap(Properties.Resources.whitePawn);
                }
                else if (aPiece.Type.Equals(Piece.Types.ROOK))
                {
                    return new Bitmap(Properties.Resources.whiteRook);
                }
                else if (aPiece.Type.Equals(Piece.Types.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.whiteKnight);
                }
                else if (aPiece.Type.Equals(Piece.Types.BISHOP))
                {
                    return new Bitmap(Properties.Resources.whiteBishop);
                }
                else if (aPiece.Type.Equals(Piece.Types.QUEEN))
                {
                    return new Bitmap(Properties.Resources.whiteQueen);
                }
                else if (aPiece.Type.Equals(Piece.Types.KING))
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

    }
}
