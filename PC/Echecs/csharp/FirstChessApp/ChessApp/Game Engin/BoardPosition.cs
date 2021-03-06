﻿using System;

namespace ChessApp.Game_Engin
{
    public class BoardPosition
    {

        public BoardPosition()
        {
            Invalid();
        }

        public BoardPosition(int ax, int ay)
        {
            this.X = ax;
            this.Y = ay;
        }

        public int X;
        public int Y;


        public Boolean IsValid()
        {
            if ((this.X >= 0) && (this.X < 8) && (this.Y >= 0) && (this.Y < 8))
                return true;
            return false;
        }

        public void Invalid()
        {
            this.X = -2;
            this.Y = -2;
        }

        public bool IsSamePosition(BoardPosition pBp)
        {
             if (pBp.X == this.X && pBp.Y == this.Y)
            {
                return true;
            }
            return false;
        }

        public override String ToString()
        {
            switch (X)
            {
                case 0: return "[A," + (Y + 1) + "]";
                case 1: return "[B," + (Y + 1) + "]";
                case 2: return "[C," + (Y + 1) + "]";
                case 3: return "[D," + (Y + 1) + "]";
                case 4: return "[E," + (Y + 1) + "]";
                case 5: return "[F," + (Y + 1) + "]";
                case 6: return "[G," + (Y + 1) + "]";
                case 7: return "[H," + (Y + 1) + "]";
                default: return "Board Position is Invalid";
            }
        }

    }
}