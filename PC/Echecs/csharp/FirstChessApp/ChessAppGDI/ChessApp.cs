using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        
        public ChessApp()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(700, 600);
        }

        
        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {
            boardPanel_x = boardPanel.Width;
            boardPanel_y = boardPanel.Height;
            g = boardPanel.CreateGraphics();
            g.Clear(Color.White);
            // The Board must be the first draw method called
            drawBoard();

            drawPieces();
        }

        
        private void drawPieces()
        {
        //    Image.FromFile("..\\..\\Resources\\Icons\\key-icon.png");

            Image image = Image.FromFile("C:\\Users\\pierr\\Documents\\GitHub\\EchecsSimple\\PC\\Echecs\\csharp\\FirstChessApp\\ChessAppGDI\\Resources\\whitePawn.gif");
            Image image2 = new Bitmap(Properties.Resources.whitePawn);
            Rectangle srcRect = new Rectangle(30, 80, 60, 60);
            g.DrawImage(image, new Point(100, 100));
            g.DrawImage(image2, srcRect);
           // g.DrawImage(image, 100, 100, srcRect, units);
        }

        



        private void drawBoard()
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
        }
    }


}
