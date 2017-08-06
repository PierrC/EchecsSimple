using ChessAppGDI.Game_Engin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class Piece
    {

        public enum Colors
        {
            BLACK,
            WHITE,
        }


        public PieceType pieceType;
        public Colors color;
        public Boolean hasMoved;

        public Piece(PieceType.Types pType, Piece.Colors pColor)
        {
            pieceType = new PieceType(pType);
            color = pColor;
            hasMoved = false;
        }

        public bool IsSameColor(Piece pPiece)
        {
            if (this.color == pPiece.color)
            {
                return true;
            }
            return false;
        }

        public override String ToString()
        {
            return pieceType.ToString();
        }

        public bool GetHasMoved()
        {
            return hasMoved;
        }


    }
}
