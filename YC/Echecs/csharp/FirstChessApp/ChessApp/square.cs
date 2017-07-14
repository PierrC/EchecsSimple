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
        private piece aPiece;
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
        public piece getPiece()
        {
            return aPiece;
        }
        public void putPiece(piece pPiece)
        {
            aPiece = pPiece;
            hasAPiece = true;
        }
        public piece removePiece()
        {
            hasAPiece = false;
            piece P = aPiece;
            aPiece = null;
            return P;
        }

    }
}
