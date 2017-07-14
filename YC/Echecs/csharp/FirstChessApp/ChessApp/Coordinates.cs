using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Coordinates
    {
        private int x;
        private int y;

        public Coordinates(int px, int py)
        {
            x = px;
            y = py;
        }

        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }

        public void SetX(int px)
        {
            x = px;
        }
        public void SetY(int py)
        {
            y = py;
        }
    }
}
