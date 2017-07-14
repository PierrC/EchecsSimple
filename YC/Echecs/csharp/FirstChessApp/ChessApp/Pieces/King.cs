using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    class King : Piece
    {

        private Players Player;
        private Colors Color;
        private Boolean hasMoved;

        public King(Players p, Colors c)
        {
            Player = p;
            Color = c;
            hasMoved = false;
        }
        public void moved()
        {
            hasMoved = true;
        }
        public Boolean hasHeMoved()
        {
            return hasMoved;
        }

    }
}
