using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI
{
    public class BoardPosition
    {
        private int x;
        private int y;

        public BoardPosition()
        {
            Invalid();
        }

        public BoardPosition(int ax, int ay)
        {
            this.X = ax;
            this.Y = ay;
        }

        public int X
        {
            get => x;
            set
            {
                if ((value >= 0) && (value < 8))
                    Invalid();
                x = value;
            }

        }
        public int Y
        {
            get => y;
            set
            {
                if ((value >= 0) && (value < 8))
                    Invalid();
                y = value;
            }
        }

        public Boolean IsValid()
        {
            if ((this.X >= 0) && (this.X < 8) && (this.Y >= 0) && (this.Y < 8))
                return true;
            return false;
        }

        public void Invalid()
        {
            this.X = -2;
            this.Y = -1;
        }

    }
}
