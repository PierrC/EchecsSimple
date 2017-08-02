using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Pawn : Piece
    {
        public Pawn(PlayerColors iColor, Position iPosition) : base(Types.PAWN, iColor, iPosition)
        {
            Steps_ = new PieceSteps();
            Steps.Multiple = false;
            Step step;

            step = new Step(1, 0);
            Steps.Steps.Add(step);
            step = new Step(2, 0);
            step.FirstMoveOnly = true;
            Steps.Steps.Add(step);
            step = new Step(1, 1);
            step.CatchMoveOnly = true;
            Steps.Steps.Add(step);
            step = new Step(-1, 1);
            step.CatchMoveOnly = true;
            Steps.Steps.Add(step);
        }
    }
}
