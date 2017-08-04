using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.Game_Engin
{
    public class MoveSet
    {
        private Boolean multiple;
        private List<Move> moves;

        public MoveSet(List<Move> list, bool multi)
        {
            if(list == null)
            {
                moves = new List<Move>();
            }
            else
            {
                moves = list;
            }
            multiple = multi;
        }

        public void addMove(Move move)
        {
            moves.Add(move);
        }

        public List<Move> getMoves()
        {
            return moves;
        }

        public Boolean IsMultiple()
        {
            return multiple;
        }

    }
}
