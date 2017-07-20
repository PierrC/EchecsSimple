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
        /// All variable
        /// 
        static int boardPanel_x, boardPanel_y;
        static int square_x, square_y, square;
        Pen mainPen = new Pen(Color.Black, 1);
        Graphics g = null;
        Font myFont = new Font("Times New Roman", 16);

        int mouse_x = 0, mouse_y = 0;
        static int selected_x, selected_y;
        Boolean isSelecting = false;
        Boolean showBoardAnnotation = true;
        ArrayList listPiece = new ArrayList();
        ChessGame game = new ChessGame(Piece.Color.WHITE);
        
        public ChessApp()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(700, 600);

            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(boardPanel);

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, boardPanel, new object[] { true });
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            g = boardPanel.CreateGraphics();
            
        }
        
        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {

            boardPanel_x = boardPanel.Width;
            boardPanel_y = boardPanel.Height;
            
            UpdateBoard();
            
        }
        
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
                    selectedPieceTextBox.Text = game.getBoardPiece()[pt.X, pt.Y].ToString() + " " + game.getBoardPiece()[pt.X, pt.Y].getColor();
                    
                }
                
                else if (!game.getBoardHasPiece()[pt.X, pt.Y] && isSelecting)
                {
                    game.movePiece(game.getBoardPiece()[selected_x, selected_y], pt);
                    selected_x = 0;
                    selected_y = 0;
                    isSelecting = false;
                    selectedPieceTextBox.Text = " ";
                }
                
            }
            UpdateBoard();
            Console.WriteLine("Mouse Point x: " + pt.X + " y: " + pt.Y);

        }

        private void boardPanel_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_x = e.X;
            mouse_y = e.Y;
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

        private void UpdateBoard()
        {
            g.Clear(Color.White);
            DrawBoard();
            DrawPieces();

        }

        private void DrawBoard()
        {
            square_x = boardPanel_x / 9;
            square_y = boardPanel_y / 9;
            square = Math.Min(square_x, square_y);
            
            for (int i = 0; i < 9; i++)
            {
                // Vertical lines
                Point p1 = new Point(square / 2, square / 2 + square * i);
                Point p2 = new Point(square / 2 + square * 8, square / 2 + square * i);
                g.DrawLine(mainPen, p1, p2);

                // Horizontal lines
                Point p3 = new Point(square / 2 + square * i, square / 2);
                Point p4 = new Point(square / 2 + square * i, square / 2 + square * 8);
                g.DrawLine(mainPen, p3, p4);
                
            }

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    int p1 = square / 2 + (2 * i * square);
                    int p2 = square / 2 + (2 * j * square);
                    g.FillRectangle(Brushes.Black, p1 , p2, square, square);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int p1 = square / 2 + square + (2 * i * square);
                    int p2 = square / 2 + square + (2 * j * square);
                    g.FillRectangle(Brushes.Black, p1, p2, square, square);
                }
            }

            if (showBoardAnnotation)
            {
                for(int i = 1; i < 9; i++)
                {
                    g.DrawString((9 - i).ToString(), myFont, Brushes.Black, square / 16, square * i - (square / 4));
                    g.DrawString( Char.ConvertFromUtf32(65 + i - 1) , myFont, Brushes.Black, square * i - (square / 4), square / 16);
                }
            }
            
        }

        private void DrawPieces()
        {

            Point pt = new Point(0,0);
            foreach(Piece p in game.getListPiece())
            {
                //PlacePieceOnBoard(p);
                pt = PlacePieceOnBoard(p);
                g.DrawImage(p.GetImage(), pt.X, pt.Y, square, square);
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // this.Refresh();
        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
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
