using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessApp.Pieces;

namespace ChessApp
{
    public class Player
    {
        piece.color aColor;
        piece.playerNumber aNumber;

        public Player(piece.color pColor, piece.playerNumber pNumber)
        {
            this.aColor = pColor;
            this.aNumber = pNumber;

        }

        public piece.color getColor()
        {
            return aColor;
        }
        public piece.playerNumber getPlayer()
        {
            return aNumber;
        }
    }
}
