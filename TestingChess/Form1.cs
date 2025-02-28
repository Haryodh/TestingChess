using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingChess //MAKE SURE THIS IS CHANGED TO YOUR PROJECT NAME DUMMY
{
    public partial class Form1 : Form
    {
        //REMEMBER TO COPY THESE SILLY BOY
        Panel panel1 = new Panel();
        Button[,] buttons = new Button[2, 8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Resize += Form1_Resize;
            panel1.BackColor = Color.Black;
            this.Controls.Add(panel1);
         
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i,j] = new Button();
                    panel1.Controls.Add(buttons[i, j]);
                    buttons[i,j].Size=new Size(buttons[i,j].Parent.Width/ buttons.GetLength(1), buttons[i, j].Parent.Height / buttons.GetLength(0));
                    buttons[i,j].Location = new Point((buttons[i, j].Parent.Width/ buttons.GetLength(1)) *j, (buttons[i, j].Parent.Height / buttons.GetLength(0)) * i);
                    buttons[i,j].FlatStyle = FlatStyle.Flat;
                    buttons[i,j].BackColor = Color.White;
                    buttons[i, j].Click += on_click;

                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int scale = 66;

            int screenwidth = this.Width;
            int screenheight = this.Height;

            int scaledwidth = (this.Width * scale / 100);
            int scaledheight = (this.Height * scale / 100);

            if (scaledwidth > scaledheight)
            {
                scaledwidth = scaledheight;
            }
            else
            {
                scaledheight = scaledwidth;
            }

            panel1.Location = new Point(screenwidth / 2 - scaledwidth / 2, screenheight / 2 - scaledheight / 2);
            panel1.Size = new Size(scaledwidth, scaledheight);
            panel1.BackColor = Color.Black;

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j].Size = new Size(buttons[i, j].Parent.Width / buttons.GetLength(1), buttons[i, j].Parent.Height / buttons.GetLength(0));
                    buttons[i, j].Location = new Point((buttons[i, j].Parent.Width / buttons.GetLength(1)) * j, (buttons[i, j].Parent.Height / buttons.GetLength(0)) * i);
                }
            }
        }

        private void on_click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Pink;
            }
            else if (button.BackColor == Color.Pink)
            {
                button.BackColor = Color.White;
            }
        }

    }
}
