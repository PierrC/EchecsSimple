using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Bishop : Piece
    {
        public Bishop(PlayerColors iColor, Position iPosition) : base(Types.BISHOP, iColor, iPosition)
        {
            Steps_ = new PieceSteps();
            Steps.Multiple = true;
            Step step;
            step = new Step(1, 1);
            Steps.Steps.Add(step);
            step = new Step(1, -1);
            Steps.Steps.Add(step);
            step = new Step(-1, 1);
            Steps.Steps.Add(step);
            step = new Step(-1, -1);
            Steps.Steps.Add(step);
        }

        public override String ToString()
        {
            return "Bishop";
        }
    }
}
