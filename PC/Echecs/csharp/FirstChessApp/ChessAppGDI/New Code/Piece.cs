using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class Piece
    {
        public enum Types
        {
            PAWN,
            ROOK,
            KNIGHT,
            BISHOP,
            QUEEN,
            KING
        }

        public enum Colors
        {
            BLACK,
            WHITE,
        }

        private Types type;
        private Colors color;

        public Types Type { get => type; }
        public Colors Color { get => color; }

        public Piece(Types iType, Colors iColor)
        {
            type = iType;
            color = iColor;
        }

        //public Colors getColor()
        //{
        //    return Color;
        //}

        //public void setColor(Colors pColor)
        //{
        //    Color = pColor;
        //}

        //public Types getPieceType()
        //{
        //    return Type1;
        //}

        //public void setPieceType(Types pPieceType)
        //{
        //    Type1 = pPieceType;
        //}

        public override String ToString()
        {
            return Type.ToString();
        }

    }
}
