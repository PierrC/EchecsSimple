using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiesObjects
{
    public partial class Form1 : Form
    {
        CustomObject co = new CustomObject();
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }
        int x = 0;
        int y = 0;
        Boolean attached = false;
        Image image = new Bitmap(Properties.Resources.whitePawn);
        Graphics g;
        

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            if (attached == true)
            {
                g.DrawImage(image, x, y, 60, 60);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            g.Clear(Color.White);
            if(attached == false)
            {
                attached = true;
            }
            else
            {
                attached = false;
                Point p = automaticPlacement(new Point(x, y));
                g.DrawImage(image, p.X, p.Y, 60, 60);
            }
        }

        private Point automaticPlacement(Point pt)
        {
            int px = pt.X;
            int py = pt.Y;
            if(px < (panel1.Width / 2))
            {
                if(py < (panel1.Height / 2))
                {
                    return new Point(10, 10);
                }
                else
                {
                    return new Point(10, panel1.Height - 50);
                }
            }
            else
            {
                if (py < (panel1.Height / 2))
                {
                    return new Point(panel1.Width - 50, 10);
                }
                else
                {
                    return new Point(panel1.Width - 70, panel1.Height - 70);
                }
            }
        }

    }
}
