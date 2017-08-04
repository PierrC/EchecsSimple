using ChessAppGDI.Game_Engin;
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
        bool hasMoved;

        public PieceView(Piece pPiece)
        {
            aPiece = pPiece;
            aImage = SetImage();
            hasMoved = false;
        }

        private Image SetImage()
        {
            if (aPiece.color == Piece.Colors.BLACK)
            {
                if (aPiece.pieceType.type == PieceType.Types.PAWN)
                {
                    return new Bitmap(Properties.Resources.blackPawn);
                }
                else if (aPiece.pieceType.type == PieceType.Types.ROOK)
                {
                    return new Bitmap(Properties.Resources.blackRook);
                }
                else if (aPiece.pieceType.type == PieceType.Types.KNIGHT)
                {
                    return new Bitmap(Properties.Resources.blackKinght);
                }
                else if (aPiece.pieceType.type == PieceType.Types.BISHOP)
                {
                    return new Bitmap(Properties.Resources.blackBishop);
                }
                else if (aPiece.pieceType.type == PieceType.Types.QUEEN)
                {
                    return new Bitmap(Properties.Resources.blackQueen);
                }
                else if (aPiece.pieceType.type == PieceType.Types.KING)
                {
                    return new Bitmap(Properties.Resources.blackKing);
                }
            }
            else
            {
                if (aPiece.pieceType.type == PieceType.Types.PAWN)
                {
                    return new Bitmap(Properties.Resources.whitePawn);
                }
                else if (aPiece.pieceType.type == PieceType.Types.ROOK)
                {
                    return new Bitmap(Properties.Resources.whiteRook);
                }
                else if (aPiece.pieceType.type == PieceType.Types.KNIGHT)
                {
                    return new Bitmap(Properties.Resources.whiteKnight);
                }
                else if (aPiece.pieceType.type == PieceType.Types.BISHOP)
                {
                    return new Bitmap(Properties.Resources.whiteBishop);
                }
                else if (aPiece.pieceType.type == PieceType.Types.QUEEN)
                {
                    return new Bitmap(Properties.Resources.whiteQueen);
                }
                else if (aPiece.pieceType.type == PieceType.Types.KING)
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

        public bool GetHasMoved()
        {
            return hasMoved;
        }

        public void HasMoved()
        {
            hasMoved = true;
        }

        public void drawImage(Graphics g, Point position)
        {
            g.DrawImage(aImage, position.X, position.Y, PositionAndPixels.square, PositionAndPixels.square);
        }

    }
}
