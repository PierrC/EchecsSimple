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
        
        private void CheckGameStatus()
        {

            if (!aChessGame.checkWhiteKing())
            {
                // event Black has won
                Boolean game = EndGame("Black Wins!");
                if (game)
                {
                    aChessGame.NewGame();
                }
                else
                {
                    this.Close();
                }
            }
            if (!aChessGame.checkBlackKing())
            {
                // event White has won
                Boolean game = EndGame("White Wins!");
                if (game)
                {
                    aChessGame.NewGame();
                }
                else
                {
                    this.Close();
                }
            }
        }
        

        private static Boolean EndGame(String pVistoryString)
        {
            Boolean value = false;
            Form prompt = new Form();
            prompt.Width = 200;
            prompt.Height = 200;

            FlowLayoutPanel panel = new FlowLayoutPanel();

            TextBox Text = new TextBox() { Text = pVistoryString };
            Button EndApp = new Button() { Text = "Close App" };
            Button Restart = new Button() { Text = "Restart Game" };

            EndApp.Click += (sender, e) => { value = false; prompt.Close(); };
            Restart.Click += (sender, e) => { value = true; prompt.Close(); };

            panel.Controls.Add(Text);
            panel.Controls.Add(EndApp);
            panel.Controls.Add(Restart);
            prompt.Controls.Add(panel);
            prompt.ShowDialog();

            return value;
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
