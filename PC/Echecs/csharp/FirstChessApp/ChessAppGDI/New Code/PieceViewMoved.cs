using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    class PieceViewMoved : PieceView
    {
        private bool hasMoved = false;
        public PieceViewMoved(Piece pPiece) : base(pPiece)
        {
        }

        public bool GetHasMoved()
        {
            return hasMoved;
        }

        public void HasBeenMoved()
        {
            hasMoved = true;
        }

    }
}
