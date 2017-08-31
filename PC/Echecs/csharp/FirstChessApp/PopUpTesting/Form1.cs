using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopUpTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TestingObject tester = ShowDialog3("Test2", "Caption2");
            Console.WriteLine(tester.ToString());
        }

        private void popUpButton1_Click(object sender, EventArgs e)
        {
            // System.Windows.Forms.MessageBox.Show("My message here");
            ShowDialog1("Test1", "Caption1");
        }

        private void popUpButton2_Click(object sender, EventArgs e)
        {
            TestingObject tester = ShowDialog3("Test2", "Caption2");
            Console.WriteLine(tester.ToString());
        }

        public static bool ShowDialog1(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 350;
            prompt.Height = 350;
            prompt.Text = caption;
            FlowLayoutPanel panel = new FlowLayoutPanel();
            CheckBox chk = new CheckBox();
            chk.Text = text;
            Button ok = new Button() { Text = "Yes" };
            ok.Click += (sender, e) => { prompt.Close(); };
            Button no = new Button() { Text = "No" };
            no.Click += (sender, e) => { prompt.Close(); };
            panel.Controls.Add(chk);
            panel.SetFlowBreak(chk, true);
            panel.Controls.Add(ok);
            panel.Controls.Add(no);
            prompt.Controls.Add(panel);
            prompt.ShowDialog();
            return chk.Checked;
        }


        public static Object ShowDialog2(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 250;
            prompt.Height = 250;
            prompt.Text = caption;
            FlowLayoutPanel panel = new FlowLayoutPanel();

            CheckedListBox chk = new CheckedListBox();
            Object obj = null;

            chk.Text = text;
            chk.Items.Add(new TestingObject("Object 1", 1));
            chk.Items.Add(new TestingObject("Object 2", 2));
            chk.Items.Add(new TestingObject("Object 3", 3));
            chk.Items.Add(new TestingObject("Object 4", 4));

            chk.Items[0] = "Object 1";
            chk.Items[1] = "Object 2";
            chk.Items[2] = "Object 3";
            chk.Items[3] = "Object 4";

            Button Selected = new Button();
            Selected.Click += new EventHandler(Selected_Click);

            Button button = new Button();
            button.Click += new EventHandler(button_Click);


            void Selected_Click(object sender, EventArgs e)
            {
                Button usedButton = sender as Button;
                // identify which button was clicked and perform necessary actions

                for (int i = 0; i < chk.Items.Count; i++)
                {
                    if (chk.GetItemCheckState(i) == CheckState.Checked)
                    {
                        obj = chk.Items[i];
                    }
                }
            }
            Point location = Selected.Location;
            location.X += 100;
            Selected.Location = location;

            // panel.Controls.Add(chk);
            panel.SetFlowBreak(chk, true);

            panel.Controls.Add(Selected);
            panel.Controls.Add(button);
            prompt.Controls.Add(panel);
            prompt.ShowDialog();

            return obj;
        }


        public static TestingObject ShowDialog3(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 250;
            prompt.Height = 250;
            prompt.Text = caption;

            TestingObject testingObj = null;

            FlowLayoutPanel panel = new FlowLayoutPanel();
            Button Object1 = new Button() { Text = "Object1" };
            Object1.Click += (sender, e) => { testingObj = new TestingObject("Test1", 1); prompt.Close(); };
            Button Object2 = new Button() { Text = "Object2" };
            Object2.Click += (sender, e) => { testingObj = new TestingObject("Test2", 2); prompt.Close(); };

            panel.Controls.Add(Object1);
            panel.Controls.Add(Object2);

            prompt.Controls.Add(panel);
            prompt.ShowDialog();
            return testingObj;
        }







        private static TestingObject Object1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private static TestingObject Object2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        private static void button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        protected Object GetObject(Object sender, EventArgs e)
        {
            // When the button is clicked,
            // change the button text, and disable it.
            Button button = sender as Button;
            Button clickedButton = (Button)sender;
            /*
            for(int i = 0; i < list.Items.Count; i++)
            {
                if (list.GetItemCheckState(i) ==  CheckState.Checked)
                {
                    return list.Items[i];
                }
            }
            */
            return null;
        }


    }
}
