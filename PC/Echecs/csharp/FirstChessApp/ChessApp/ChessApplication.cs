using ChessApp.Game_Engin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApp
{
    public partial class ChessApplication : Form
    {
        ChessGame aChessGame;
        Graphics g = null;
        int mouse_x, mouse_y;

        public ChessApplication()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(700, 600);
            checkedListBox1.SetItemCheckState(2, CheckState.Checked);
            
            aChessGame = new ChessGame();
        }

        private void boardPanel_MouseClick(object sender, MouseEventArgs e)
        {
            mouse_x = e.X;
            mouse_y = e.Y;

            Point mousePoint = new Point(mouse_x, mouse_y);
            BoardPosition bp = PositionAndPixels.PixelsToBoardPosition(mousePoint);

            if (e.Button == MouseButtons.Right)
            {
                aChessGame.DiscardPiece();
            }
            else
            {
                aChessGame.ManipulatePiece(bp);
            }
            // selectedPieceTextBox.Text = aChessGame.SelectedPieceString();
            
            Refresh();
        }

        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {
            PositionAndPixels.boardPanel_x = boardPanel.Width;
            PositionAndPixels.boardPanel_y = boardPanel.Height;
            PositionAndPixels.Update();

            g = e.Graphics;
            UpdateBoard();

        }

        private void UpdateBoard()
        {
            g.Clear(Color.White);
            aChessGame.DrawGame(g);
        }



        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

    }
}
