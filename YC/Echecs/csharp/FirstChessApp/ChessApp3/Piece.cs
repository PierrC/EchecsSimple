﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp3
{
    public class Piece
    {
        private Boolean IsBlack_;

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

        Types Type { get; set; }
        Image aImage { get; set; }
        Position Position { get; set; }

        public bool IsBlack { get => IsBlack_; }

        public Image GetImage()
        {
            return aImage;
        }


        public Piece(Types iType, PlayerColors iColor, Position iPosition)
        {
            Type = iType;
            IsBlack_ = iColor == PlayerColors.BLACK ? true : false;
            Position.Row = iPosition.Row;
            Position.Column = iPosition.Column;
        }


        private Image SetImage()
        {
            if (this.IsBlack)/// PlayerColor.Equals(PlayerColors.BLACK))
            {
                if (Type.Equals(Types.PAWN))
                {
                    return new Bitmap(Properties.Resources.blackPawn);
                }
                else if (Type.Equals(Types.ROOK))
                {
                    return new Bitmap(Properties.Resources.blackRook);
                }
                else if (Type.Equals(Types.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.blackKinght);
                }
                else if (Type.Equals(Types.BISHOP))
                {
                    return new Bitmap(Properties.Resources.blackBishop);
                }
                else if (Type.Equals(Types.QUEEN))
                {
                    return new Bitmap(Properties.Resources.blackQueen);
                }
                else if (Type.Equals(Types.KING))
                {
                    return new Bitmap(Properties.Resources.blackKing);
                }
            }
            else
            {
                if (Type.Equals(Types.PAWN))
                {
                    return new Bitmap(Properties.Resources.whitePawn);
                }
                else if (Type.Equals(Types.ROOK))
                {
                    return new Bitmap(Properties.Resources.whiteRook);
                }
                else if (Type.Equals(Types.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.whiteKnight);
                }
                else if (Type.Equals(Types.BISHOP))
                {
                    return new Bitmap(Properties.Resources.whiteBishop);
                }
                else if (Type.Equals(Types.QUEEN))
                {
                    return new Bitmap(Properties.Resources.whiteQueen);
                }
                else if (Type.Equals(Types.KING))
                {
                    return new Bitmap(Properties.Resources.whiteKing);
                }
            }
            return null;
        }

    }
}