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
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            int x, y;
            x = 150;
            y = 80;

            for (int j = 1; j <= 9; j++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    this.button1 = new System.Windows.Forms.Button();
                    // 
                    // button1
                    // 
                    this.button1.BackColor = Color.Aqua;
                    this.button1.ForeColor = Color.Black;
                    this.button1.Name = "button1";
                    this.button1.Size = new System.Drawing.Size(50, 50);
                    this.button1.Location = new System.Drawing.Point(x, y);
                    this.button1.TabIndex = 0;
                    this.button1.Text = "";
                    this.button1.UseVisualStyleBackColor = false;
                    this.Controls.Add(button1);
                    this.button1.Click += new System.EventHandler(this.button_Click);
                    x = x + 50;
                }
                y = y + 50;
                x = 150;
            }
        }
        private System.Windows.Forms.Button button1;

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = textBox1.Text;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control != button2)
                {
                    ((Button)control).Text = "";
                }
            }

            List<Button> buttons = new List<Button>();
            foreach (Control control in this.Controls)
            {
                if (control is Button && control != button2)
                {
                    buttons.Add((Button)control);
                }
            }

            int count = 0;
            while (count < 21 && buttons.Count > 0)
            {
                int index = random.Next(0, buttons.Count);
                Button button = buttons[index];
                button.Text = random.Next(1, 21).ToString();
                buttons.RemoveAt(index);
                count++;
            }
            buttons.Clear();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics mygraphics = e.Graphics;
            SolidBrush mybrush = new SolidBrush(Color.Black);
            mygraphics.FillRectangle(mybrush, 140, 75, 470, 460);

        }
    }
    
}

