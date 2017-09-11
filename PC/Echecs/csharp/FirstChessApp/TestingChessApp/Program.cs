using ChessApp.Game_Engin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingChessApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ChessBoard aChessBoard = new ChessBoard();
            Assert.IsTrue(aChessBoard.CheckWhiteKing());
            for (int i = 0; i < 8; i++)
            {
                aChessBoard.GetBoard()[0, i].RemovePiece();
            }
            Assert.IsFalse(aChessBoard.CheckWhiteKing());

        }
    }
}
