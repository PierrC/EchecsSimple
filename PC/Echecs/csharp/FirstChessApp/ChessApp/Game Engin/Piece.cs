using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin
{
    class Piece
    {
        public enum Color
        {
            WHITE,
            BLACK
        }

        PieceType aType;
        Color aColor;
        Boolean hasMoved;


        public Piece(PieceType pType, Color pColor)
        {
            aType = pType;
            aColor = pColor;
            hasMoved = false;
        }

    }
}
