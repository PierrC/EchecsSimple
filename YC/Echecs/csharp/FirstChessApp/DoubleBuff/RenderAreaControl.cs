using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleBuff
{
    public partial class RenderAreaControl : UserControl
    {
        private BufferedGraphicsContext context;
        private BufferedGraphics grafx;

        private byte bufferingMode;
        private string[] bufferingModeStrings =
            { "Draw to Form without OptimizedDoubleBufferring control style",
          "Draw to Form using OptimizedDoubleBuffering control style",
          "Draw to HDC for form" };

        public RenderAreaControl()
        {
            InitializeComponent();

            InitializeDoubleBuffering();
        }

        void InitializeDoubleBuffering()
        {
            // 
            // DoubleBufferedForm
            // 
            this.Text = "User double buffering";
            this.MouseDown += new MouseEventHandler(this.MouseDownHandler);
            this.Resize += new EventHandler(this.OnResize);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            // Configure a timer to draw graphics updates.
            //timer1 = new System.Windows.Forms.Timer();
            //timer1.Interval = 200;
            //timer1.Tick += new EventHandler(this.OnTimer);

            bufferingMode = 2;

            // Retrieves the BufferedGraphicsContext for the 
            // current application domain.
            context = BufferedGraphicsManager.Current;

            // Sets the maximum size for the primary graphics buffer
            // of the buffered graphics context for the application
            // domain.  Any allocation requests for a buffer larger 
            // than this will create a temporary buffered graphics 
            // context to host the graphics buffer.
            context.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);

            // Allocates a graphics buffer the size of this form
            // using the pixel format of the Graphics created by 
            // the Form.CreateGraphics() method, which returns a 
            // Graphics object that matches the pixel format of the form.
            grafx = context.Allocate(this.CreateGraphics(),
                 new Rectangle(0, 0, this.Width, this.Height));

            // Draw the first frame to the buffer.
            DrawToBuffer(grafx.Graphics, true);
        }

        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Cycle the buffering mode.
                if (++bufferingMode > 2)
                    bufferingMode = 0;

                // If the previous buffering mode used 
                // the OptimizedDoubleBuffering ControlStyle,
                // disable the control style.
                if (bufferingMode == 1)
                    this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

                // If the current buffering mode uses
                // the OptimizedDoubleBuffering ControlStyle,
                // enabke the control style.
                if (bufferingMode == 2)
                    this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);

                // Cause the background to be cleared and redraw.
                DrawToBuffer(grafx.Graphics, true);
                this.Refresh();
            }
        }

        private void OnResize(object sender, EventArgs e)
        {
            // Re-create the graphics buffer for a new window size.
            context.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);
            if (grafx != null)
            {
                grafx.Dispose();
                grafx = null;
            }
            grafx = context.Allocate(this.CreateGraphics(),
                new Rectangle(0, 0, this.Width, this.Height));

            // Cause the background to be cleared and redraw.
            DrawToBuffer(grafx.Graphics, true);
            this.Refresh();
        }

        private void DrawToBuffer(Graphics g, bool drawBackground)
        {
            // Clear the graphics buffer every five updates.
            if (drawBackground)
            {
                grafx.Graphics.FillRectangle(Brushes.White, 0, 0, this.Width, this.Height);
            }

            DrawBoard(g);


            // Draw information strings.
            //g.DrawString("Buffering Mode: " + bufferingModeStrings[bufferingMode], new Font("Arial", 8), Brushes.Red, 10, 10);
            //g.DrawString("Right-click to cycle buffering mode", new Font("Arial", 8), Brushes.Red, 10, 22);
            //g.DrawString("Left-click to toggle timed display refresh", new Font("Arial", 8), Brushes.Red, 10, 34);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            grafx.Render(e.Graphics);
        }

        private void DrawBoard(Graphics g)
        {
            int boardPanel_x = this.Width;
            int boardPanel_y = this.Height;

            int square_x = boardPanel_x / 9;
            int square_y = boardPanel_y / 9;
            int square = Math.Min(square_x, square_y);
            Pen mainPen = new Pen(Color.Black, 1);

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

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int p1 = square / 2 + (2 * i * square);
                    int p2 = square / 2 + (2 * j * square);
                    g.FillRectangle(Brushes.Black, p1, p2, square, square);
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
            bool showBoardAnnotation = true;
            Font myFont = new Font("Arial", 16);

            if (showBoardAnnotation)
            {
                for (int i = 1; i < 9; i++)
                {
                    g.DrawString((9 - i).ToString(), myFont, Brushes.Black, square / 16, square * i - (square / 4));
                    g.DrawString(Char.ConvertFromUtf32(65 + i - 1), myFont, Brushes.Black, square * i - (square / 4), square / 16);
                }
            }

        }

    }
}
