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
        Colors color;
        public Types Type { get => type; }
        public Colors Color { get => color; }

        public Piece(Types pType, Colors pColor)
        {
            type = pType;
            color = pColor;
        }

        public bool IsSameColor(Piece pPiece)
        {
            if (this.Color == pPiece.Color)
            {
                return true;
            }
            return false;
        }


    }
}
