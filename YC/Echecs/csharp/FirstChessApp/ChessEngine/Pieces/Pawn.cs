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

            int direction = IsBlack ? -1 : 1;
            step = new Step(0, 1 * direction);
            Steps.Steps.Add(step);
            step = new Step(0, 2 * direction);
            step.FirstMoveOnly = true;
            Steps.Steps.Add(step);
            step = new Step(1, 1 * direction);
            step.CatchMoveOnly = true;
            Steps.Steps.Add(step);
            step = new Step(-1, 1 * direction);
            step.CatchMoveOnly = true;
            Steps.Steps.Add(step);
        }
    }
}
