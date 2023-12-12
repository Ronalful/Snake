using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Media;

namespace Snake
{
    public partial class Form1 : Form
    {       
               
        public static Apple myApple = new Apple();
        public Snake[] s;
        public SnakeControle mySnakeControle = new SnakeControle(myApple);       
                
        bool flag = false;
        int count;
        int turn = 1;
        int timer_tic;
        
        public Form1()
        {
            InitializeComponent();
            Init();               
        }

        public void Init()
        {
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();            
        }

        private void Update(object sender, EventArgs e)
        {
            if (flag)
            {
                if (mySnakeControle.MoveControle(s, turn))
                {
                    Lose();
                }
                else
                {                   
                    mySnakeControle.Move(ref s, turn);
                    if(mySnakeControle.Eat(s))
                    {                       
                        mySnakeControle.Grow(ref s);                       
                        count += 1;
                        label_count.Text = count.ToString();
                        if (count == 97)
                        {                            
                            Win();
                        }
                        else
                            myApple.SetCoord(s);
                    }

                    pictureBox1.Invalidate();
                }
            }
                    
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;            

            g.Clear(Color.Gray);

            Pen lines = new Pen(Color.Black, 1);

            for (int i = 0; i <= 500; i += 50)
            {
                g.DrawLine(lines, i, 0, i, 500);
                g.DrawLine(lines, 0, i, 500, i);
            }

            if (flag)
            {
                mySnakeControle.BuildSnake(g, s);
                myApple.Build(g);
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            flag = true;
            s = new Snake[3];
            s[0] = new Snake(200, 200);
            s[1] = new Snake(200, 250);
            s[2] = new Snake(200, 300);           
            myApple.SetCoord(s);
            label_end.Visible = false;
            turn = 1;
            count = 0;
            label_count.Text = count.ToString();

            if (radioButton_slow.Checked)
                timer_tic = 500;
            else if (radioButton_medium.Checked)
                timer_tic = 250;
            else if (radioButton_fast.Checked)
                timer_tic = 125;
            else
                timer_tic = 65;

            radioButton_turbo.Enabled = false;
            radioButton_fast.Enabled = false;
            radioButton_medium.Enabled = false;
            radioButton_slow.Enabled = false;
            timer1.Interval = timer_tic;
            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    turn = 1;
                    break;
                case Keys.A:
                    turn = 2;
                    break;
                case Keys.S:
                    turn = 3;
                    break;
                case Keys.D:
                    turn = 4;
                    break;
            }
        }

        public void EndAnimation()
        {
            Graphics g = pictureBox1.CreateGraphics();            

            for (int y = 0; y <= 450; y += 50)
            {
                for (int x = 0; x <= 450; x += 50)
                {
                    g.FillRectangle(Brushes.White, x + 1, y + 1, 49, 49);
                    if (y != 0)
                        g.FillRectangle(Brushes.Gray, x + 1, y - 49, 49, 49);
                }
                
                Thread.Sleep(60);
            }
            pictureBox1.Invalidate();
        }

        public void Win()
        {
            flag = false;
            EndAnimation();
            label_end.Text = "YOU WIN!!";
            label_end.Visible = true;
            radioButton_turbo.Enabled = true;
            radioButton_fast.Enabled = true;
            radioButton_medium.Enabled = true;
            radioButton_slow.Enabled = true;           
        }

        public void Lose()
        {
            flag = false;
            EndAnimation();
            label_end.Text = "GAME OVER";
            label_end.Visible = true;
            radioButton_turbo.Enabled = true;
            radioButton_fast.Enabled = true;
            radioButton_medium.Enabled = true;
            radioButton_slow.Enabled = true;
        }
    }
}
