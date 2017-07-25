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

            if ((bp.Row >= 0) & (bp.Row < 8) & (bp.Column >= 0) & (bp.Column < 8))
            {
                if (chessGame.Board.HasPiece[bp.Row, bp.Column] && !isSelecting)
                {
                    selectedPosition = new BoardPosition(bp.Row, bp.Column);
                    isSelecting = true;
                    //  selectedPieceTextBox.Text = game.getBoardPiece()[pt.Row, pt.Column].ToString() + " " + game.getBoardPiece()[pt.Row, pt.Column].getColor();
                    selectedPieceTextBox.Text = chessGame.Board.Squares[bp.Row, bp.Column].ToString();
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

            if ((bp.Row >= 0) & (bp.Row < 8) & (bp.Column >= 0) & (bp.Column < 8))
            {
                Console.WriteLine("bp: " + bp.Row + " " + bp.Column);
                if (chessGame.Board.HasPiece[bp.Row, bp.Column] && !isSelecting)
                {
                    Console.WriteLine("Option 1");
                    selectedPosition = new BoardPosition(bp.Row, bp.Column);
                    isSelecting = true;
                    selectedPieceTextBox.Text = chessGame.Board.Squares[bp.Row, bp.Column].ToString() + " " + bp.ToString();
                }
                else if (isSelecting && (bp.Row == selectedPosition.Row) && (bp.Column == selectedPosition.Column))
                {
                    Console.WriteLine("Option 2");
                    selectedPosition = new BoardPosition(-2, -1);
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
                else if (isSelecting &&
                    chessGame.Board.HasPiece[bp.Row, bp.Column] &&
                    chessGame.Board.Squares[bp.Row, bp.Column].Color.Equals(ChessBoard.OtherColor(chessGame.Board.Squares[selectedPosition.Row, selectedPosition.Column].Color)))
                {
                    Console.WriteLine("Option 3");
                    chessGame.movePiece(selectedPosition, bp);
                    selectedPosition = new BoardPosition(-2, -1);
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
                else if(isSelecting && !chessGame.Board.HasPiece[bp.Row, bp.Column])
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
            if ((pt.Row >= 0) & (pt.Row < 8) & (pt.Column >= 0) & (pt.Column < 8))
            {
                if (game.getBoardHasPiece()[pt.Row, pt.Column] && !isSelecting)
                {
                    selected_x = pt.Row;
                    selected_y = pt.Column;
                    isSelecting = true;
                    //  selectedPieceTextBox.Text = game.getBoardPiece()[pt.Row, pt.Column].ToString() + " " + game.getBoardPiece()[pt.Row, pt.Column].getColor();
                    selectedPieceTextBox.Text = game.getBoardPiece()[pt.Row, pt.Column].ToString();
                }
                else if (isSelecting && (pt.Row == selected_x) && (pt.Column == selected_y))
                {
                    selected_x = -1;
                    selected_y = -1;
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
                else if (game.getBoardHasPiece()[pt.Row, pt.Column] && 
                    game.getBoardPiece()[pt.Row, pt.Column].getColor().Equals( ChessGame.OtherColor( game.getBoardPiece()[selected_x, selected_y].getColor()) ) 
                    && isSelecting)
                {
                    game.movePiece(game.getBoardPiece()[selected_x, selected_y], pt);
                    selected_x = -1;
                    selected_y = -1;
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
                else if (!game.getBoardHasPiece()[pt.Row, pt.Column] && isSelecting)
                {
                    game.movePiece(game.getBoardPiece()[selected_x, selected_y], pt);
                    selected_x = -1;
                    selected_y = -1;
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
            }
            UpdateBoard();
            Console.WriteLine("Mouse Point x: " + pt.Row + " y: " + pt.Column);

        }

        
        


        private static void PiecePlacement(Piece p)
        {
            
            Point pt = p.GetPoint();

            int x = (pt.Row - (square / 2)) / square;
            x = Math.Min(x * square, square * 8);
            x += square / 2;

            int y = (pt.Column - (square / 2)) / square;
            y = Math.Min(y * square, square * 8);
            y += square / 2;

            p.SetPoint(new Point (x, y));
        }

        private static Point PlacePieceOnBoard(Piece p)
        {
            Point pt = p.GetPoint();
            return new Point((square / 2) + pt.Row * square, (square / 2) + pt.Column * square);
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
