using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class ChessGameView
    {
        ChessGame chessGame;

        public ChessGameView()
        {
            chessGame = new ChessGame();
        }
        
        public ChessGame GetChessGame()
        {
            return chessGame;
        }

        public void DrawBoard(Graphics g)
        {
            chessGame.getChessBoardView().DrawGame(g);
        }


    }
}
