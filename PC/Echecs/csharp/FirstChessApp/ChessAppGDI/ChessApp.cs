using ChessAppGDI.New_Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessAppGDI
{
    public partial class ChessApp : Form
    {

        Pen mainPen = new Pen(Color.Black, 1);
        Graphics g = null;
        Font myFont = new Font("Times New Roman", 16);

        ChessGameView chessGameView;
        
        int mouse_x = 0, mouse_y = 0;
        
        public ChessApp()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(700, 600);
            
            chessGameView =  new ChessGameView();
            checkedListBox1.SetItemCheckState(2, CheckState.Checked);
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
            chessGameView.DrawBoard(g);
        }

        private void boardPanel_MouseClick(object sender, MouseEventArgs e)
        {
            mouse_x = e.X;
            mouse_y = e.Y;
            Point mousePoint = new Point(mouse_x, mouse_y);
            BoardPosition bp = PositionAndPixels.PixelsToBoardPosition(mousePoint);
            if (e.Button == MouseButtons.Right)
            {
                chessGameView.GetChessGame().DiscardPiece();
            }
            else
            {
                chessGameView.GetChessGame().MovePiece(bp);
            }
            selectedPieceTextBox.Text = chessGameView.GetChessGame().PrintPiece();
            HasKings();
            Refresh();
        }

        public void HasKings()
        {
            if (!chessGameView.GetChessGame().HasKing())
            {
                if (chessGameView.GetChessGame().KingKilled() == Piece.Colors.WHITE)
                {
                    chessGameView = new ChessGameView();
                    winnerLabel.Text = "Black Won";
                }
                else
                {
                    chessGameView = new ChessGameView();
                    winnerLabel.Text = "White Won";
                }

            }
        }
        
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chessGameView = new ChessGameView();
        }

        private void choseButton_Click(object sender, EventArgs e)
        {

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                if (checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(itemChecked)))
                {
                    int i = checkedListBox1.Items.IndexOf(itemChecked);
                    chessGameView.GetChessGame().SetConvertPiece(i);
                }
            }
        }
        
        private void testButton_Click(object sender, EventArgs e)
        {
            int i = 1;
        //    ChessBoard list = chessGameView.GetChessGame().getChessBoardView().GetChessBoard();
            List <BoardPosition> test = chessGameView.GetChessGame().getChessBoardView().GetChessBoard().GetAvaibleMoves(new BoardPosition(input_x, input_y));
            
            
            foreach(BoardPosition b in test)
            {
                Console.WriteLine(i + " " + b.ToString());
                i++;
            }
            Console.WriteLine();
        }

        int input_x = 0;
        int input_y = 0;
        private void textBox1_Click(object sender, EventArgs e)
        {
            input_x = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            input_y = Convert.ToInt32(textBox2.Text);
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
