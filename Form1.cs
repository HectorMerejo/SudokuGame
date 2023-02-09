using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics mygraphics = e.Graphics;
            SolidBrush mybrush = new SolidBrush(Color.Black);
            mygraphics.FillRectangle(mybrush, 140, 75, 470, 470);
            Boolean blue = true;
            int x, y;
            x = 153;
            y = 85;
            for (int j = 1; j <= 9; j++)
            {
                for (int i = 1; i <= 9; i++)
                {

                    if (blue)
                    {
                        mybrush = new SolidBrush(Color.Blue);
                    }

                    mygraphics.FillRectangle(mybrush, x, y, 45, 45);
                    x = x + 50;
                    blue = !blue;
                }
                y = y + 50;
                x = 175;
                blue = !blue;
            }

        }
    }
}

