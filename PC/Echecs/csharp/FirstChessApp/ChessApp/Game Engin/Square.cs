using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin
{
    public class Square
    {
        Piece aPiece;
        Boolean isDark;

        public Square(bool b)
        {
            aPiece = null;
            isDark = b;
        }

        public Boolean HasPiece()
        {
            if (aPiece == null)
            {
                return false;
            }
            return true;
        }

        public Piece GetPiece()
        {
            return aPiece;
        }

        public void SetPiece(Piece pPiece)
        {
            aPiece = pPiece;
        }

        public void RemovePiece()
        {
            aPiece = null;
        }

        public Boolean SquareIsDark()
        {
            return isDark;
        }

        public override string ToString()
        {
            if (!(aPiece == null))
                return aPiece.ToString();
            return "";
        }


    }
}
