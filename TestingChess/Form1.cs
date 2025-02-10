using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingChess
{
    public partial class Form1 : Form
    {
        Button[,] buttons = new Button[8, 8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons[i,j] = new Button();
                    panel1.Controls.Add(buttons[i, j]);
                    buttons[i,j].Size=new Size(buttons[i,j].Parent.Width/8, buttons[i, j].Parent.Height / 8);
                    buttons[i,j].Location = new Point((buttons[i, j].Parent.Width/8)*j, (buttons[i, j].Parent.Height / 8) * i);
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

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons[i, j].Size = new Size(buttons[i, j].Parent.Width / 8, buttons[i, j].Parent.Height / 8);
                    buttons[i, j].Location = new Point((buttons[i, j].Parent.Width / 8) * j, (buttons[i, j].Parent.Height / 8) * i);
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
