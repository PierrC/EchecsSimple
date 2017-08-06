using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class King : Piece
    {
        public King(PlayerColors iColor, Position iPosition) : base(Types.KING, iColor, iPosition)
        {
            Steps_ = new PieceSteps();
            Steps.Multiple = false;
            Step step;
            
            step = new Step(1, 1);
            Steps.Steps.Add(step);
            step = new Step(1, -1);
            Steps.Steps.Add(step);
            step = new Step(-1, 1);
            Steps.Steps.Add(step);
            step = new Step(-1, -1);
            Steps.Steps.Add(step);

            step = new Step(1, 0);
            Steps.Steps.Add(step);
            step = new Step(0, 1);
            Steps.Steps.Add(step);
            step = new Step(-1, 0);
            Steps.Steps.Add(step);
            step = new Step(0, -1);
            Steps.Steps.Add(step);
            
        }
    }
}
