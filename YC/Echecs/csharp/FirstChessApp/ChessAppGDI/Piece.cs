﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI
{
    class Piece
    {
        public enum PieceType
        {
            PAWN,
            ROOK,
            KNIGHT,
            BISHOP,
            QUEEN,
            KING 
        }
        public enum Player
        {
            PLAYER1,
            PLAYER2
        }
        public enum Color
        {
            BLACK,
            WHITE
        }

        PieceType aType { get; set; }
        Player aPlayer { get; set; } 
        Color aColor { get; set; }
        Image aImage { get; set; }
        Point aCoor { get; set; }


        public Point GetPoint()
        {
            return aCoor;
        }

        public void SetPoint(Point pt)
        {
            aCoor = pt;
        }

        public Image GetImage()
        {
            return aImage;
        }

        public Piece(PieceType pType, Player pPlayer, Color pColor, Point pCoor)
        {
            aType = pType;
            aPlayer = pPlayer;
            aColor = pColor;
            aCoor = pCoor;
            aImage = SetImage();
        }
        public Piece(PieceType pType, Player pPlayer, Color pColor, int x, int y)
        {
            aType = pType;
            aPlayer = pPlayer;
            aColor = pColor;
            aCoor = new Point(x , y);
            aImage = SetImage();
        }

        private Image SetImage()
        {
            if (aColor.Equals(Color.BLACK))
            {
                if (aType.Equals(PieceType.PAWN))
                {
                    return new Bitmap(Properties.Resources.blackPawn);
                }
                else if (aType.Equals(PieceType.ROOK))
                {
                    return new Bitmap(Properties.Resources.blackRook);
                }
                else if (aType.Equals(PieceType.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.blackKinght);
                }
                else if (aType.Equals(PieceType.BISHOP))
                {
                    return new Bitmap(Properties.Resources.blackBishop);
                }
                else if (aType.Equals(PieceType.QUEEN))
                {
                    return new Bitmap(Properties.Resources.blackQueen);
                }
                else if (aType.Equals(PieceType.KING))
                {
                    return new Bitmap(Properties.Resources.blackKing);
                }
            }
            else
            {
                if (aType.Equals(PieceType.PAWN))
                {
                    return new Bitmap(Properties.Resources.whitePawn);
                }
                else if (aType.Equals(PieceType.ROOK))
                {
                    return new Bitmap(Properties.Resources.whiteRook);
                }
                else if (aType.Equals(PieceType.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.whiteKnight);
                }
                else if (aType.Equals(PieceType.BISHOP))
                {
                    return new Bitmap(Properties.Resources.whiteBishop);
                }
                else if (aType.Equals(PieceType.QUEEN))
                {
                    return new Bitmap(Properties.Resources.whiteQueen);
                }
                else if (aType.Equals(PieceType.KING))
                {
                    return new Bitmap(Properties.Resources.whiteKing);
                }
            }
            return null;
        }

    }
}
