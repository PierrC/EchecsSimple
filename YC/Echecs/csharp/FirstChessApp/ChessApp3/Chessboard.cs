using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp3
{
    /// <summary>
    /// Desribed the Chessboard as 2d array of Squares
    /// The first index is for row iwth Square ranging from A to H
    /// The second index is for column iwth Square ranging from 1 to 8
    /// </summary>
    public class Chessboard
    {
        public Square[,] Squares = new Square[8, 8];

        /// <summary>
        /// 
        /// </summary>
        public Chessboard()
        {
            bool Dark = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Position iPos = new Position();
                    iPos.Row = i;
                    iPos.Column = j;
                    Squares[i, j] = new Square(Dark? Square.Colors.DARK: Square.Colors.LIGHT, iPos);
                    Dark = !Dark;
                }
                Dark = !Dark;
            }
        }

        public Square GetSquare(Position IPos)
        {
            if (!IPos.IsValid)
                return null;
            return Squares[IPos.Row, IPos.Column];
        }
    }
}
