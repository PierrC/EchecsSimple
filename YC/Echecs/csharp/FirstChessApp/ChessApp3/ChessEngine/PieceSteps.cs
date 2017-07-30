﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Step
    {
        public int DeltaRom, DeltaColumn;
        public bool FirstMoveOnly;
        public bool CatchMoveOnly;

        public Step(int dr, int dc)
        {
            DeltaRom = dr;
            DeltaColumn = dc;
        }
    }

    class PieceSteps
    {
        Boolean Multiple_;

        public bool Multiple { get => Multiple_; set => Multiple_ = value; }
        public List<Step> Steps;
    }
}