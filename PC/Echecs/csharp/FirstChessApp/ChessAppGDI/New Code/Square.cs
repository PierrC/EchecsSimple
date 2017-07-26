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
        Piece piece;
        bool hasPiece;

        public Square()
        {
            piece = null;
            hasPiece = false;
        }

        public Piece GetPiece()
        {
            return piece;
        }

        public bool HasPiece()
        {
            return hasPiece;
        }

        public void SetPiece(Piece pPiece)
        {
            piece = pPiece;
            if (!pPiece.Equals(null))
            {
                hasPiece = true;
            }
        }

        public void RemovePiece()
        {
            piece = null;
            hasPiece = false;
        }

        public override string ToString()
        {
            return piece.ToString();
        }



    }
}
