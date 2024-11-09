using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string shapeName = textBox1.Text.ToLower().Trim();


            using (Graphics g = pictureBox1.CreateGraphics())
            {

                g.Clear(pictureBox1.BackColor);

     
                switch (shapeName)
                {
                    case "circle":

                        g.DrawEllipse(Pens.Black, 10, 10, 100, 100);
                        break;
                    case "square":

                        g.DrawRectangle(Pens.Black, 10, 10, 100, 100); 
                        break;
                    case "rectangle":

                        g.DrawRectangle(Pens.Black, 10, 10, 150, 100);
                        break;
                    case "ellipse":

                        g.DrawEllipse(Pens.Black, 10, 10, 150, 100); 
                        break;
                    case "triangle":

                        Point[] points = {
                            new Point(60, 10), 
                            new Point(10, 110), 
                            new Point(110, 110) 
                        };
                        g.DrawPolygon(Pens.Black, points);
                        break;
                    default:
                        MessageBox.Show($"Invalid shape ({shapeName}). Please enter 'circle', 'square', 'rectangle', 'ellipse', or 'triangle'.");
                        break;
                }
            }
        }
    }
}
