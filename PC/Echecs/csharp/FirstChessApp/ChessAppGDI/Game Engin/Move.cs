using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.Game_Engin
{
    public class Move
    {
        public int DeltaRow; // { get => DeltaRow; set { this.DeltaRow = value; } }
        public int DeltaColumn; // { get => DeltaRow; set { this.DeltaRow = value; } }
        public bool FirstMoveOnly;
        public bool CatchMoveOnly;

        public Move(int dr, int dc)
        {
            DeltaRow = dr;
            DeltaColumn = dc;
            FirstMoveOnly = false;
            CatchMoveOnly = false;
        }

        public Move(int dr, int dc, bool firstMove, bool catchMove)
        {
            DeltaRow = dr;
            DeltaColumn = dc;
            FirstMoveOnly = firstMove;
            CatchMoveOnly = catchMove;
        }

        

    }
}
