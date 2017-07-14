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
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(co.getPosition() == 1)
            {
                panel1.Location = new Point(13, 76);
            }
            else if(co.getPosition() == 2)
            {
                panel1.Location = new Point(76, 76);
            }
            else if (co.getPosition() == 3)
            {
                panel1.Location = new Point(137, 76);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            co.setPosition(1);
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            co.setPosition(2);
            panel1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            co.setPosition(3);
            panel1.Invalidate();
        }
    }
}
