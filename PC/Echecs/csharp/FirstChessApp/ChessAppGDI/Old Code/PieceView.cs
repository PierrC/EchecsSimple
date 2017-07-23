using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI
{
    public class PieceView
    {
        Piece aPiece { get; set; }
        Image aImage { get; set; }
        BoardPosition aPosi { get; set; }

        public PieceView(Piece pPiece)
        {
            aPiece = pPiece;
            aImage = SetImage();
            aPosi = new BoardPosition(-2, -1);
        }

        private String ToStringCoor()
        {
            switch (aPosi.X)
            {
                case 0: return "[A," + (8 - aPosi.Y) + "]";
                case 1: return "[B," + (8 - aPosi.Y) + "]";
                case 2: return "[C," + (8 - aPosi.Y) + "]";
                case 3: return "[D," + (8 - aPosi.Y) + "]";
                case 4: return "[E," + (8 - aPosi.Y) + "]";
                case 5: return "[F," + (8 - aPosi.Y) + "]";
                case 6: return "[G," + (8 - aPosi.Y) + "]";
                case 7: return "[H," + (8 - aPosi.Y) + "]";
                default: return "0";
            }
        }

        private Image SetImage()
        {
            if (aPiece.getColor().Equals(Piece.Color.BLACK))
            {
                if (aPiece.GetType().Equals(Piece.PieceType.PAWN))
                {
                    return new Bitmap(Properties.Resources.blackPawn);
                }
                else if (aPiece.GetType().Equals(Piece.PieceType.ROOK))
                {
                    return new Bitmap(Properties.Resources.blackRook);
                }
                else if (aPiece.GetType().Equals(Piece.PieceType.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.blackKinght);
                }
                else if (aPiece.GetType().Equals(Piece.PieceType.BISHOP))
                {
                    return new Bitmap(Properties.Resources.blackBishop);
                }
                else if (aPiece.GetType().Equals(Piece.PieceType.QUEEN))
                {
                    return new Bitmap(Properties.Resources.blackQueen);
                }
                else if (aPiece.GetType().Equals(Piece.PieceType.KING))
                {
                    return new Bitmap(Properties.Resources.blackKing);
                }
            }
            else
            {
                if (aPiece.GetType().Equals(Piece.PieceType.PAWN))
                {
                    return new Bitmap(Properties.Resources.whitePawn);
                }
                else if (aPiece.GetType().Equals(Piece.PieceType.ROOK))
                {
                    return new Bitmap(Properties.Resources.whiteRook);
                }
                else if (aPiece.GetType().Equals(Piece.PieceType.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.whiteKnight);
                }
                else if (aPiece.GetType().Equals(Piece.PieceType.BISHOP))
                {
                    return new Bitmap(Properties.Resources.whiteBishop);
                }
                else if (aPiece.GetType().Equals(Piece.PieceType.QUEEN))
                {
                    return new Bitmap(Properties.Resources.whiteQueen);
                }
                else if (aPiece.GetType().Equals(Piece.PieceType.KING))
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
        public BoardPosition GetPosition()
        {
            return aPosi;
        }
        public Image GetImage()
        {
            return aImage;
        }
        public void drawPiece(Graphics g)
        {
            g.DrawImage(aImage, new Point(aPosi.X, aPosi.Y));
        }
        

        public void setPiece(Piece pPiece)
        {
            aPiece = pPiece;
        }
        public void SetPosition(Point pt)
        {
            aPosi = new BoardPosition(pt.X, pt.Y);
        }
        public void SetPosition(BoardPosition BPosition)
        {
            aPosi = BPosition;
        }


        

        
    }
}
