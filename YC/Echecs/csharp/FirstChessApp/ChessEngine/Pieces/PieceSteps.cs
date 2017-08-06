using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class Step
    {
        public int DeltaColumn, DeltaRow;
        public bool FirstMoveOnly;
        public bool CatchMoveOnly;

        public Step(int dc, int dr)
        {
            DeltaColumn = dc;
            DeltaRow = dr;
            FirstMoveOnly = false;
            CatchMoveOnly = false;
        }
    }

    public class PieceSteps
    {
        Boolean Multiple_;

        public bool Multiple { get => Multiple_; set => Multiple_ = value; }
        public List<Step> Steps;

        public PieceSteps()
        {
            Steps = new List<Step>();
        }
    }

}
