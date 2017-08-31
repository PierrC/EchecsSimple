using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApp.Game_Engin
{
    public class PromotionManipulator
    {
        Piece.PieceType aPromotionType;
        
        public PromotionManipulator()
        {
            aPromotionType = Piece.PieceType.QUEEN;
        }

        public void PromotePawn(BoardPosition bp, ChessBoard aBoard)
        {
            int i = ChoosePiece();
            SetPromotionPiece(i);
            ReplacePawn(bp, aBoard);
        }

        public void ReplacePawn(BoardPosition bp, ChessBoard aBoard)
        {
            Piece replacement;
            if (bp.Y == 7)
            {
                replacement = new Piece(aPromotionType, Piece.Color.WHITE);
            }
            else
            {
                replacement = new Piece(aPromotionType, Piece.Color.BLACK);
            }
            aBoard.GetBoard()[bp.X, bp.Y].SetPiece(replacement);

        }

        public void SetPromotionPiece(int i)
        {
            switch (i)
            {
                case 0:
                    aPromotionType = Piece.PieceType.BISHOP;
                    break;
                case 1:
                    aPromotionType = Piece.PieceType.KNIGHT;
                    break;
                case 2:
                    aPromotionType = Piece.PieceType.QUEEN;
                    break;
                case 3:
                    aPromotionType = Piece.PieceType.ROOK;
                    break;
                default:
                    aPromotionType = Piece.PieceType.QUEEN;
                    break;
            }
        }

        private static int ChoosePiece()
        {
            int value = 3;
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 300;

            FlowLayoutPanel panel = new FlowLayoutPanel();

            Button Bishop = new Button() { Text = "Bishop" };
            Button Knight = new Button() { Text = "Knight" };
            Button Queen = new Button() { Text = "Queen" };
            Button Rook = new Button() { Text = "Rook" };

            Bishop.Click += (sender, e) => { value = 0; prompt.Close(); };
            Knight.Click += (sender, e) => { value = 1; prompt.Close(); };
            Queen.Click += (sender, e) => { value = 2; prompt.Close(); };
            Rook.Click += (sender, e) => { value = 3; prompt.Close(); };

            panel.Controls.Add(Bishop);
            panel.Controls.Add(Knight);
            panel.Controls.Add(Queen);
            panel.Controls.Add(Rook);
            prompt.Controls.Add(panel);
            prompt.ShowDialog();

            return value;
        }

    }
}
