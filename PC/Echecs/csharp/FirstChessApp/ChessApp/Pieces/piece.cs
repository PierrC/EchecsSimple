using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    public class piece
    {
        public enum color
        {
            WHITE,
            BLACK
        }
        public enum playerNumber
        {
            PLAYER1,
            PLAYER2
        }


        private playerNumber Player;
        private color Color;
        private Coordinates Coor;

        public color returnColor()
        {
            return Color;
        }

        public playerNumber GetPlayer()
        {
            return Player;
        }

        public Coordinates GetCoor()
        {
            return Coor;
        }

        public void SetCoor(Coordinates pCoor)
        {
            Coor = pCoor;
        }


    };
}
