using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin
{
    public class Piece
    {
        public enum Color
        {
            WHITE,
            BLACK
        }
        public enum PieceType
        {
            PAWN,
            ROOK,
            KNIGHT,
            BISHOP,
            QUEEN,
            KING
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

        public PieceType GetPieceType()
        {
            return aType;
        }

        public Color GetColor()
        {
            return aColor;
        }

        public bool GetHasMoved()
        {
            return hasMoved;
        }

        public void IsMoved()
        {
            hasMoved = true;
        }

        public bool IsSameColor(Object p)
        {
            if (this.GetType().Equals(p.GetType()))
            {
                return (this.GetColor() == ((Piece)p).GetColor());
            }
            else if(this.GetColor().GetType().Equals(p.GetType()))
            {
                return (this.GetColor() == ((Color)p));
            }
            return false;
        }

        public override String ToString()
        {
            return aColor.ToString() + " " + aType.ToString();
        }


        public override Boolean Equals(Object obj)
        {
            if (obj.GetType().Equals(this.GetType()))
            {
                Piece p = (Piece)obj;
                if(this.aType == p.aType && this.aColor == p.aColor)
                {
                    return true;
                }
                    
            }
            return false;
        }
    }
}
