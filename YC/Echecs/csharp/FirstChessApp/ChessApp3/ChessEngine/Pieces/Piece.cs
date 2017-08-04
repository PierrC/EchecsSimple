using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessApp3;

namespace ChessEngine
{
    public class Piece
    {
        private Boolean IsBlack_;
        protected PieceSteps Steps_;

        public enum Types
        {
            PAWN,
            ROOK,
            KNIGHT,
            BISHOP,
            QUEEN,
            KING
        }

        public enum PlayerColors
        {
            BLACK,
            WHITE
        }

        public Types Type { get; }
        public Image Image { get; }
        public Position Position { get; set; }
        

        public bool IsBlack { get => IsBlack_; }
        public PieceSteps Steps { get => Steps_; set => Steps_ = value; }

        public Image GetImage()
        {
            return Image;
        }


        public Piece(Types iType, PlayerColors iColor, Position iPosition)
        {
            Type = iType;
            IsBlack_ = iColor == PlayerColors.BLACK ? true : false;
            Position = new Position(iPosition.Column, iPosition.Row);
            this.Image = SetImage();
            Steps_ = null;
        }


        private Image SetImage()
        {
            if (this.IsBlack)/// PlayerColor.Equals(PlayerColors.BLACK))
            {
                if (this.Type == Piece.Types.PAWN)
                {
                    return new Bitmap(ChessApp3.Properties.Resources.blackPawn);
                }
                else if (Type.Equals(Types.ROOK))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.blackRook);
                }
                else if (Type.Equals(Types.KNIGHT))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.blackKinght);
                }
                else if (Type.Equals(Types.BISHOP))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.blackBishop);
                }
                else if (Type.Equals(Types.QUEEN))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.blackQueen);
                }
                else if (Type.Equals(Types.KING))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.blackKing);
                }
            }
            else
            {
                if (Type.Equals(Types.PAWN))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.whitePawn);
                }
                else if (Type.Equals(Types.ROOK))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.whiteRook);
                }
                else if (Type.Equals(Types.KNIGHT))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.whiteKnight);
                }
                else if (Type.Equals(Types.BISHOP))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.whiteBishop);
                }
                else if (Type.Equals(Types.QUEEN))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.whiteQueen);
                }
                else if (Type.Equals(Types.KING))
                {
                    return new Bitmap(ChessApp3.Properties.Resources.whiteKing);
                }
            }
            return null;
        }

    }
}
