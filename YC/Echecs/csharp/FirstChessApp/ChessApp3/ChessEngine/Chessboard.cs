using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    /// <summary>
    /// Desribed the Chessboard as 2d array of Squares
    /// The first index is for row iwth Square ranging from A to H
    /// The second index is for column iwth Square ranging from 1 to 8
    /// </summary>
    public class Chessboard
    {
        public Square[] Squares = new Square[8 * 8];

        /// <summary>
        /// 
        /// </summary>
        public Chessboard()
        {
            bool Dark = false;
            for (int irow = 0; irow < 8; irow++)
            {
                for (int icol = 0; icol < 8; icol++)
                {
                    Position iPos = new Position(icol, irow);
                    Squares[irow * 8 + icol] = new Square(Dark? Square.Colors.DARK: Square.Colors.LIGHT, iPos);
                    Dark = !Dark;
                }
                Dark = !Dark;
            }
        }

        public Square GetSquare(Position IPos)
        {
            if (!IPos.IsValid)
                return null;
            return Squares[IPos.Row * 8 + IPos.Column];
        }
    }
}
