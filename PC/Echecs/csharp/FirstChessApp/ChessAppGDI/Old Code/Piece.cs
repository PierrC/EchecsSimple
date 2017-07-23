using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI
{
    public class Piece
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

        public enum Color
        {
            BLACK,
            WHITE,
        }

        PieceType aType { get; set; }
        Color aColor { get; set; }


        public override String ToString()
        {
            return aType.ToString();
        }
        
        public Color getColor()
        {
            return aColor;
        }

        public void setColor(Color pColor)
        {
            aColor = pColor;
        }

        public PieceType getPieceType()
        {
            return aType;
        }

        public void setPieceType(PieceType pPieceType)
        {
            aType = pPieceType;
        }

        public Piece(PieceType pType, Color pColor)
        {
            aType = pType;
            aColor = pColor;
        }

        


    }
}
