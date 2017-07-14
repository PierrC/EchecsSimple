using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessApp.Pieces;

namespace ChessApp
{
    public class square
    {
        private Piece aPiece;
        private Boolean hasAPiece;

        public square()
        {
            aPiece = null;
            hasAPiece = false;
        }
        public Boolean hasPiece()
        {
            return hasAPiece;
        }
        public Piece getPiece()
        {
            return aPiece;
        }
        public void putPiece(Piece pPiece)
        {
            aPiece = pPiece;
            hasAPiece = true;
        }
        public Piece removePiece()
        {
            hasAPiece = false;
            Piece P = aPiece;
            aPiece = null;
            return P;
        }

    }
}
