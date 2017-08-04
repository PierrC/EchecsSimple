using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class Square
    {
        private Boolean isDark;
        Piece piece;
        public bool IsDark { get => isDark; }

        public Square(bool isdark)
        {
            piece = null;
            isDark = isdark;
        }

        public Piece GetPiece()
        {
            return piece;
        }

        public bool HasPiece()
        {
            return piece != null;
        }

        public void SetPiece(Piece pPiece)
        {
            piece = pPiece;
        }

        public void RemovePiece()
        {
            SetPiece(null);
        }

        public override string ToString()
        {
            if (!(piece == null))
                return piece.ToString();
            return "";
        }



    }
}
