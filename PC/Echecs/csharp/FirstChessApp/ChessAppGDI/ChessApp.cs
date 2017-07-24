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
        int i = PositionAndPixels.boardPanel_x ;
        Pen mainPen = new Pen(Color.Black, 1);
        Graphics g = null;
        Font myFont = new Font("Times New Roman", 16);

        ChessBoardView chessGame;

        int mouse_x = 0, mouse_y = 0;
        ArrayList listPiece = new ArrayList();

        Boolean isSelecting = false;
        BoardPosition selectedPosition;
        

        public ChessApp()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(700, 600);

            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(boardPanel);
            chessGame =  new ChessBoardView();
            
        }

        private void boardPanel_MouseMove(object sender, MouseEventArgs e)
        {
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
            chessGame.DrawGame(g);
        }


        private void boardPanel_Click(object sender, EventArgs e)
        {
            Point mousePoint = new Point(mouse_x, mouse_y);
            BoardPosition bp = PositionAndPixels.PixelsToBoardPosition(mousePoint);

            if ((bp.X >= 0) & (bp.X < 8) & (bp.Y >= 0) & (bp.Y < 8))
            {
                if (chessGame.GetChessBoard().GetHasPiece()[bp.X, bp.Y] && !isSelecting)
                {
                    selectedPosition = new BoardPosition(bp.X, bp.Y);
                    isSelecting = true;
                    //  selectedPieceTextBox.Text = game.getBoardPiece()[pt.X, pt.Y].ToString() + " " + game.getBoardPiece()[pt.X, pt.Y].getColor();
                    selectedPieceTextBox.Text = chessGame.GetChessBoard().GetBoard()[bp.X, bp.Y].ToString();
                }



            }



            Refresh();
        }



        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        private void boardPanel_Click_1(object sender, EventArgs e)
        {
            Point mousePoint = new Point(mouse_x, mouse_y);
            BoardPosition bp = PositionAndPixels.PixelsToBoardPosition(mousePoint);

            if ((bp.X >= 0) & (bp.X < 8) & (bp.Y >= 0) & (bp.Y < 8))
            {
                Console.WriteLine("bp: " + bp.X + " " + bp.Y);
                if (chessGame.GetChessBoard().GetHasPiece()[bp.X, bp.Y] && !isSelecting)
                {
                    Console.WriteLine("Option 1");
                    selectedPosition = new BoardPosition(bp.X, bp.Y);
                    isSelecting = true;
                    selectedPieceTextBox.Text = chessGame.GetChessBoard().GetBoard()[bp.X, bp.Y].ToString() + " " + bp.ToString();
                }
                else if (isSelecting && (bp.X == selectedPosition.X) && (bp.Y == selectedPosition.Y))
                {
                    Console.WriteLine("Option 2");
                    selectedPosition = new BoardPosition(-2, -1);
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
                else if (isSelecting &&
                    chessGame.GetChessBoard().GetHasPiece()[bp.X, bp.Y] &&
                    chessGame.GetChessBoard().GetBoard()[bp.X, bp.Y].getColor().Equals(ChessBoard.OtherColor(chessGame.GetChessBoard().GetBoard()[selectedPosition.X, selectedPosition.Y].getColor())))
                {
                    Console.WriteLine("Option 3");
                    chessGame.movePiece(selectedPosition, bp);
                    selectedPosition = new BoardPosition(-2, -1);
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
                else if(isSelecting && !chessGame.GetChessBoard().GetHasPiece()[bp.X, bp.Y])
                {
                    Console.WriteLine("Option 4");
                    chessGame.movePiece(selectedPosition, bp);
                    selectedPosition = new BoardPosition(-2, -1);
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }

            }

            Refresh();
        }

        private void boardPanel_MouseMove_1(object sender, MouseEventArgs e)
        {

            mouse_x = e.X;
            mouse_y = e.Y;
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





////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                
        /*
        /// All variable
        /// 

        
        
        
        // testing 
        private void boardPanel_DoubleClick(object sender, EventArgs e)
        {

        }

        private void player1WhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new ChessGame(Piece.Color.WHITE);
            UpdateBoard();
        }

        private void player1BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new ChessGame(Piece.Color.BLACK);
            UpdateBoard();
        }

        private void boardPanel_Click(object sender, EventArgs e)
        {
            Point pt = selectSquare(mouse_x, mouse_y);
            if ((pt.X >= 0) & (pt.X < 8) & (pt.Y >= 0) & (pt.Y < 8))
            {
                if (game.getBoardHasPiece()[pt.X, pt.Y] && !isSelecting)
                {
                    selected_x = pt.X;
                    selected_y = pt.Y;
                    isSelecting = true;
                    //  selectedPieceTextBox.Text = game.getBoardPiece()[pt.X, pt.Y].ToString() + " " + game.getBoardPiece()[pt.X, pt.Y].getColor();
                    selectedPieceTextBox.Text = game.getBoardPiece()[pt.X, pt.Y].ToString();
                }
                else if (isSelecting && (pt.X == selected_x) && (pt.Y == selected_y))
                {
                    selected_x = -1;
                    selected_y = -1;
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
                else if (game.getBoardHasPiece()[pt.X, pt.Y] && 
                    game.getBoardPiece()[pt.X, pt.Y].getColor().Equals( ChessGame.OtherColor( game.getBoardPiece()[selected_x, selected_y].getColor()) ) 
                    && isSelecting)
                {
                    game.movePiece(game.getBoardPiece()[selected_x, selected_y], pt);
                    selected_x = -1;
                    selected_y = -1;
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
                else if (!game.getBoardHasPiece()[pt.X, pt.Y] && isSelecting)
                {
                    game.movePiece(game.getBoardPiece()[selected_x, selected_y], pt);
                    selected_x = -1;
                    selected_y = -1;
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
            }
            UpdateBoard();
            Console.WriteLine("Mouse Point x: " + pt.X + " y: " + pt.Y);

        }

        
        


        private static void PiecePlacement(Piece p)
        {
            
            Point pt = p.GetPoint();

            int x = (pt.X - (square / 2)) / square;
            x = Math.Min(x * square, square * 8);
            x += square / 2;

            int y = (pt.Y - (square / 2)) / square;
            y = Math.Min(y * square, square * 8);
            y += square / 2;

            p.SetPoint(new Point (x, y));
        }

        private static Point PlacePieceOnBoard(Piece p)
        {
            Point pt = p.GetPoint();
            return new Point((square / 2) + pt.X * square, (square / 2) + pt.Y * square);
        }
        private Point selectSquare(int x, int y)
        {
            x = (x - (square / 2)) / square;
            y = (y - (square / 2)) / square;

            return new Point(x, y);
        }

       
    */

    }


}
