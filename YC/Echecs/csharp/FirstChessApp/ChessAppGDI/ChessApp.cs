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

        Boolean showBoardAnnotation = true;
        ArrayList listPiece = new ArrayList();

        
        public ChessApp()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(700, 600);

            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(boardPanel);

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, boardPanel, new object[] { true });
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            g = boardPanel.CreateGraphics();
            Piece p1 = new Piece(Piece.PieceType.PAWN, Piece.Player.PLAYER1, Piece.Color.BLACK, new Point(100, 100));
            Piece p2 = new Piece(Piece.PieceType.PAWN, Piece.Player.PLAYER1, Piece.Color.WHITE, new Point(130, 130));
            listPiece.Add(p1);
            listPiece.Add(p2);
            
        }

        
        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {

            boardPanel_x = boardPanel.Width;
            boardPanel_y = boardPanel.Height;
            
            // g.Clear(Color.White);
            // The Board must be the first draw method called
            UpdateBoard();
            
        }

        // Not final version of method
        private void DrawPieces()
        {
            foreach(Piece p in listPiece)
            {
                g.DrawImage(p.GetImage(), p.GetPoint().X, p.GetPoint().Y, 60, 60);
            }
        }

        int x = 0,y = 0;

        private void boardPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Piece p = (Piece)listPiece[1];
            p.SetPoint(new Point( e.X, e.Y));
            listPiece[1] = p;
        }

        // testing 
        private void boardPanel_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void testDragMethod()
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
             this.Refresh();
            //  UpdateBoard();

            // this.Invalidate();
        }

        // Point[] arrayPoint = new Point[]();
        private void updateBoardSize()
        {


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
