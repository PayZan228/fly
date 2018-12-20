using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        pole ground = new pole();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            render();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void render()
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            for (int i = 0; i < 11; i++)
            {
                int x;
                x = pictureBox1.Width / 11;
                x *= i;
                //y = pictureBox1.Height / 15;
                //y *= j;

                Point p1 = new Point(x, 0);
                Point p2 = new Point(x, pictureBox1.Height);
                Pen ruch = new Pen(Color.Aqua);
                g.DrawLine(ruch, p1, p2);
            }
            for (int i = 0; i < 11; i++)
            {
                int y;
                y = pictureBox1.Height / 11;
                y *= i;
                Point p3 = new Point(0, y);
                Point p4 = new Point(pictureBox1.Width, y);
                Pen ruch2 = new Pen(Color.Aqua);
                g.DrawLine(ruch2, p3, p4);
            }

            for (int x =0; x< 11; x++)
                for(int y=0; y<11; y++)
                {
                    var gghghg = ground.polee[x, y];
                    var br1 = new SolidBrush(Color.Red);
                    var br2 = new SolidBrush(Color.Green);
                    Rectangle rect = new Rectangle(pictureBox1.Width / 11 * x, pictureBox1.Height / 11 * y, 10, 10);
                    Point p5 = new Point(pictureBox1.Width / 11 * x, pictureBox1.Height / 11 * y);
                    if (ground.polee[x, y].type == 1)
                    {

                    }
                    else
                    {
                        Image newImage = Image.FromFile("Recourse/unnamed_2.png");
                        g.DrawImage(newImage, p5);
                    }
                }
        }
        

    }
}
