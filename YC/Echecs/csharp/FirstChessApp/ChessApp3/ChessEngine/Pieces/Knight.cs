using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Knight : Piece
    {
        public Knight(PlayerColors iColor, Position iPosition) : base( Types.KNIGHT, iColor, iPosition)
        {
            Steps_ = new PieceSteps();
            Steps.Multiple = false;
            Step step;
            step = new Step(1, 2);
            Steps.Steps.Add(step);
            step = new Step(2, 1);
            Steps.Steps.Add(step);
            step = new Step(-1, 2);
            Steps.Steps.Add(step);
            step = new Step(-2, 1);
            Steps.Steps.Add(step);

            step = new Step(1, -2);
            Steps.Steps.Add(step);
            step = new Step(2, -1);
            Steps.Steps.Add(step);
            step = new Step(-1, -2);
            Steps.Steps.Add(step);
            step = new Step(-2, -1);
            Steps.Steps.Add(step);

        }
    }
}
