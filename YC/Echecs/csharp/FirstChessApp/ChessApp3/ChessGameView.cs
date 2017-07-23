using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessApp3
{
    public class ChessGameView
    {
        private ChessGame Game_;

        public ChessGame Game { get => Game_;}

        public ChessGameView(ChessGame IGame)
        {
            Game_ = IGame;
        }

        public void DrawGame(Graphics g, PositionPixel PP)
        {
            if (Game == null)
                return;

            if (Game.Board != null)
            {
                DrawChessboard(Game.Board, g, PP);
            }
            if (Game.BlackPieces != null)
            {
                DrawPieceSet(Game.BlackPieces, g, PP);
            }
            if (Game.WhitePieces != null)
            {
                DrawPieceSet(Game.WhitePieces, g, PP);
            }
        }

        private void DrawChessboard(Chessboard Board, Graphics g, PositionPixel PP)
        {

        }

        private void DrawPieceSet(PieceSet Set, Graphics g, PositionPixel PP)
        {

        }
    }
}
