using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessApp.Game_Engin;

namespace ChessAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChessBoard aChessBoard = new ChessBoard();
            Assert.IsTrue( aChessBoard.CheckWhiteKing());
            for(int i = 0; i < 8; i++)
            {
                aChessBoard.GetBoard()[0, i].RemovePiece();
            }
            Assert.IsFalse(aChessBoard.CheckWhiteKing());

        }
    }
}
