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

        
        public PieceType pieceType { get => pieceType; set { this.pieceType = value; } }
        public Colors color { get => color; set { this.color = value; } }
        

        public Piece(PieceType.Types pType, Piece.Colors pColor)
        {
            pieceType = new PieceType(pType);
            color = pColor;
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

    }
}
