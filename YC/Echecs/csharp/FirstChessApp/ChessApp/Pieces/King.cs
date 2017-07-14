using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    class King : piece
    {

        private playerNumber Player;
        private color Color;
        private Boolean hasMoved;

        public King(playerNumber p, color c)
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
